using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Responses;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserResponse>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();

            return _mapper.Map<List<UserResponse>>(users);
        }

        public async Task<UserResponse> GetById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserResponse>(user);
        }
        public async Task<User> GetByUsername(string username)
        {
            return await _userRepository.GetAsync(p => p.UserName.Equals(username));
        }
        public async Task Add(User user)
        {
            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _userRepository.DeleteAsync(id);
            await _userRepository.SaveChangesAsync();
        }


        public async Task Update(User user)
        {
            _userRepository.Update(user);
            await _userRepository.SaveChangesAsync();
        }

        public async Task<List<UserResponse>> GetParticipantByPollId(int pollId)
        {
            var participants = await _userRepository.GetParticipantByPollId(pollId);
            return _mapper.Map<List<UserResponse>>(participants);
        }
    }
}
