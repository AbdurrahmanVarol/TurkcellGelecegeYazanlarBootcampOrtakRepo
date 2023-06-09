﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Services;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Business.Mapping;
using VotingApp.Business.Dtos.Requests.PollRequests;
using VotingApp.Business.Dtos.Requests.UserRequests;
using VotingApp.Business.Dtos.Requests.OptionRequests;
using VotingApp.Entities;
using VotingApp.Business.Dtos.Requests.VoteRequests;

namespace VotingApp.Business.Tests
{
    public class PollServiceTest
    {
        private IPollRepository _pollRepository;
        private IPollService _pollService;
        private IUserRepository _userRepository;
        private IUserService _userService;
        private IAuthService _authService;
        private IVoteRepository _voteRepository;
        private IVoteService _voteService;
        private int _userId;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<VotingDbContext>()
                .UseInMemoryDatabase(databaseName: "VotingAppDb").Options;
            var context = new VotingDbContext(options);

            _pollRepository = new EfPollRepository(context);
            IMapper mapper = new MapperConfiguration(o => o.AddProfile(new DefaultMapper())).CreateMapper();
            _pollService = new PollService(_pollRepository, mapper);

            _userRepository = new EfUserRepository(context);
            _userService = new UserService(_userRepository, mapper);
            _authService = new AuthService(_userService, mapper);
            var user = new RegisterRequest
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                PasswordConfirm = "test",
                UserName = "test"
            };
            _authService.RegisterAsync(user).GetAwaiter().GetResult();
            _userId = _userService.GetByUsername("test").GetAwaiter().GetResult().Id;

            _voteRepository = new EfVoteRepository(context);
            _voteService = new VoteService(_voteRepository, _userService, _pollService, mapper);
        }
        [Test]
        public void CreatePollTest()
        {
            var request = new CreatePollRequest
            {
                CreatedById = _userId,
                Title = "Title",
                Description = "Description",
                OptionNames = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" }
            };
            var result = _pollService.CreatePollAsync(request).GetAwaiter().GetResult();
            var optionCount = _pollService.GetByIdAsync(1).GetAwaiter().GetResult().Options.Count;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(true));
                Assert.That(optionCount, Is.EqualTo(4));
            });
        }

        [Test]
        public void UpdatePollTest()
        {
            var request = new CreatePollRequest
            {
                CreatedById = _userId,
                Title = "Title",
                Description = "Description",
                OptionNames = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" }
            };
            var result = _pollService.CreatePollAsync(request).GetAwaiter().GetResult();
            var addedPoll = _pollService.GetByIdAsync(1).GetAwaiter().GetResult();

            var options = addedPoll.Options.Select(p => new CreateOptionRequest
            {
                Id = p.Id,
                PollId = addedPoll?.Id,
                Value = p.Value,
            }).ToList();
            options.Add(new CreateOptionRequest
            {
                Id = null,
                PollId = addedPoll.Id,
                Value = "Option 5"
            });
            var updateRequest = new UpdatePollRequest
            {
                Id = addedPoll.Id,
                Title = "Title2",
                Description = "Description2",
                Options = options
            };
            _pollService.Update(updateRequest).GetAwaiter().GetResult();
            var poll = _pollService.GetByIdAsync(addedPoll.Id).GetAwaiter().GetResult();
            Assert.Multiple(() =>
            {
                Assert.That(poll.Title, Is.EqualTo("Title2"));
                Assert.That(poll.Description, Is.EqualTo("Description2"));
                Assert.That(poll.Options, Has.Count.EqualTo(5));
            });
            Assert.That(poll.Options.Any(p => p.Value == "Option 5"), Is.EqualTo(true));
        }

        [Test]
        public void DeletePollTest()
        {
            var request = new CreatePollRequest
            {
                CreatedById = _userId,
                Title = "Title",
                Description = "Description",
                OptionNames = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" }
            };
            var result = _pollService.CreatePollAsync(request).GetAwaiter().GetResult();


            var deletePollRequest = new DeletePollRequest
            {
                Id = 1
            };
            _pollService.DeletePollById(deletePollRequest).GetAwaiter().GetResult();
            var addedPoll = _pollService.GetByIdAsync(1).GetAwaiter().GetResult();

            Assert.That(addedPoll, Is.EqualTo(null));
        }
        [Test]
        public void SoftDeletePollTest()
        {
            var request = new CreatePollRequest
            {
                CreatedById = _userId,
                Title = "Title",
                Description = "Description",
                OptionNames = new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" }
            };
            var result = _pollService.CreatePollAsync(request).GetAwaiter().GetResult();

            var deletePollRequest = new DeletePollRequest
            {
                Id = 1
            };

            _pollService.DeletePollAsSoftById(deletePollRequest).GetAwaiter().GetResult();
            var addedPoll = _pollService.GetByIdAsync(1).GetAwaiter().GetResult();

            Assert.That(addedPoll.IsDeleted, Is.EqualTo(true));
        }
        [Test]
        public void GetActivePollsTest()
        {
            var polls = new List<Poll>
            {
                new Poll
                {
                    CreatedById = _userId,
                    Title = "Title",
                    Description = "Description",
                    Options = new List<Option> { new Option { Value= "Option 1" }, new Option { Value = "Option 2" } }
                },
                 new Poll
                {
                    CreatedById = _userId,
                    Title = "Title2",
                    Description = "Description2",
                    Options = new List<Option> { new Option { Value= "Option 1" }, new Option { Value = "Option 2" } }
                }
            };
            _pollRepository.AddRangeAsync(polls).GetAwaiter().GetResult();
            _pollRepository.SaveChangesAsync();          

            var vote = new Vote
            {
                OptionId = 1,
                UserId = _userId,
            };
            _voteRepository.AddAsync(vote).GetAwaiter().GetResult();
            _pollRepository.SaveChangesAsync();

            var activePolls = _pollService.GetActivePolls(1).GetAwaiter().GetResult();

            Assert.Multiple(() =>
            {
                Assert.That(activePolls, Has.Count.EqualTo(1));
                Assert.That(activePolls.First().Title, Is.EqualTo("Title2"));
                Assert.That(activePolls.First().Description, Is.EqualTo("Description2"));
                Assert.That(activePolls.First().Options, Has.Count.EqualTo(2));
            });
        }
    }
}
