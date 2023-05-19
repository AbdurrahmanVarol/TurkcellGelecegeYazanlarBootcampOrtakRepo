using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Dtos.Requests.UserRequests;
using VotingApp.Business.Dtos.Responses;

namespace VotingApp.Business.Services
{
    public interface IAuthService
    {
        Task<UserResponse> LoginAsync(LoginRequest loginRequest);
        Task RegisterAsync(RegisterRequest registerRequest);
        void CreatePasswordHash(string password, out string passwordHash, out string passwordSalt);
        bool VerifyPasswordHash(string password, string passwordHash, string passwordSalt);
    }
}
