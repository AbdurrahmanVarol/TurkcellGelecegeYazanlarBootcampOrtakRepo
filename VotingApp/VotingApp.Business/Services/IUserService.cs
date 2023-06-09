﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Dtos.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services
{
    public interface IUserService
    {
        public Task<List<UserResponse>> GetAllAsync();
        public Task<UserResponse> GetById(int id);
        public Task<User> GetByUsername(string username);
        Task<List<UserResponse>> GetParticipantByPollId(int pollId);

        public Task Add(User user);
        public Task Delete(int id);
        public Task Update(User user);


    }
}
