using AutoMapper;
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
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AuthService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public void CreatePasswordHash(string password, out string passwordHash, out string passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = Convert.ToBase64String(hmac.Key);
            passwordHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        public async Task<UserResponse> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userService.GetByUsername(loginRequest.UserName);
            if (user == null)
            {
                throw new ArgumentException("Kullanıcı bulunamadı!!!");
            }
            if (!VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new ArgumentException("Şifre hatalı!!!");
            }
            return _mapper.Map<UserResponse>(user);
        }

        public bool VerifyPasswordHash(string password, string passwordHash, string passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(Convert.FromBase64String(passwordSalt));

            var computedHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));

            return passwordHash.Equals(computedHash);
        }

        public async Task RegisterAsync(RegisterRequest registerRequest)
        {
            //TODO: Validasyon eklenecek
            string passwordHash = string.Empty;
            string passwordSalt = string.Empty;

            CreatePasswordHash(registerRequest.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                UserName = registerRequest.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedAt = DateTime.Now,
            };
            await _userService.Add(user);
        }
    }
}
