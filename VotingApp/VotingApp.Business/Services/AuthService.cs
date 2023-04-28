using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Business.Requests;
using VotingApp.Business.Responses;

namespace VotingApp.Business.Services
{
    public class AuthService : IAuthService
    {
        public void CreatePasswordHash(string password, out string passwordHash, out string passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = Convert.ToBase64String(hmac.Key);
            passwordHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        public Task<UserResponse> LoginAsync(LoginRequest loginRequest)
        {
            //TODO: Bu metot UserService oluşturulduktan sonra doldurulacak
            throw new NotImplementedException();
        }

        public bool VerifyPasswordHash(string password, string passwordHash, string passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(Convert.FromBase64String(passwordSalt));

            var computedHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));

            return passwordHash.Equals(computedHash);
        }

        public Task RegisterAsync(RegisterRequest registerRequest)
        {
            //TODO: Bu metot UserService oluşturulduktan sonra doldurulacak
            //TODO: Validasyon eklenecek
            string passwordHash = string.Empty;
            string passwordSalt = string.Empty;

            CreatePasswordHash(registerRequest.Password, out passwordHash, out passwordSalt);
            throw new NotImplementedException();
        }
    }
}
