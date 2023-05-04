using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;
using VotingApp.Entities;

namespace VotingApp.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;

        public UserService(EfUserRepository efUserRepository)
        {
            this.UserRepository = UserRepository;
        }

        public Task<List<User>> GetAllAsync()
        {
            return this.UserRepository.GetAllAsync();
        }

        public Task<User> GetById(int id)
        {
            return this.UserRepository.GetByIdAsync(id);
        }
        public void Add(User user)
        {
            this.UserRepository.AddAsync(user);
        }

        public void Delete(int id)
        {
            UserRepository.DeleteAsync(id);
        }


        public void Update(User user)
        {
            this.UserRepository.Update(user);
        }
    }
}
