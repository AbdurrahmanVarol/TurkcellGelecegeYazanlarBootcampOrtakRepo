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
        public void Add(User user);
        public void Delete(int id);
        public void Update(User user);


    }
}
