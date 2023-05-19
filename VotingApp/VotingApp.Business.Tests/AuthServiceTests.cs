using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Dtos.Requests.UserRequests;
using VotingApp.Business.Mapping;
using VotingApp.Business.Services;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;

namespace VotingApp.Business.Tests
{
    public class AuthServiceTests
    {
        private IUserRepository _userRepository;
        private IUserService _userService;
        private IAuthService _authService;
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<VotingDbContext>()
                .UseInMemoryDatabase(databaseName: "VotingAppDb").Options;
            var context = new VotingDbContext(options);
            _userRepository = new EfUserRepository(context);
            IMapper mapper = new MapperConfiguration(o => o.AddProfile(new DefaultMapper())).CreateMapper();
            _userService = new UserService(_userRepository, mapper);
            _authService = new AuthService(_userService,mapper);
        }

        [Test]
        public void RegisterTest()
        {
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

            var addedUser = _userService.GetByUsername("test");

            Assert.IsNotNull(addedUser);
        }
        [Test]
        public void LoginWithCorrectPasswotdTest()
        {
            var addedUser = new RegisterRequest
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                PasswordConfirm = "test",
                UserName = "test"
            };
            _authService.RegisterAsync(addedUser).GetAwaiter().GetResult();

            var user = _authService.LoginAsync(new LoginRequest
            {
                UserName = "test",
                Password = "test"
            }).GetAwaiter().GetResult();
            Assert.IsNotNull(user);
        }
        [Test]
        public void LoginWithWrongPasswotdTest()
        {
            var addedUser = new RegisterRequest
            {
                FirstName = "test",
                LastName = "test",
                Email = "test",
                Password = "test",
                PasswordConfirm = "test",
                UserName = "test"
            };
            _authService.RegisterAsync(addedUser).GetAwaiter().GetResult();

            var user = _authService.LoginAsync(new LoginRequest
            {
                UserName = "test",
                Password = "test11"
            }).GetAwaiter().GetResult();
            Assert.IsNull(user);
        }
    }
}
