using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;
using VotingApp.Entities;

namespace VotingApp.Business.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> GetById(int id);
        public Task<User> GetByUsername(string username);
		public Task Add(User user);
        public Task Delete(int id);
        public Task Update(User user);


    }
}
