using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ILoginService
    {
        Task<LoginAuthenticateResult> AuthenticateAsync(LoginAuthenticateRequestArgs args);
    }

    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHashProvider _hashProvider;

        public LoginService()
        {
            _userRepository = new UserRepository(UserRecords.Records);
            _hashProvider = new HashProvider();
        }

        public async Task<LoginAuthenticateResult> AuthenticateAsync(LoginAuthenticateRequestArgs args)
        {
            var result = new LoginAuthenticateResult();

            var user = await _userRepository.GetByUsernameAsync(args.Username!);
            if (user != null)
            {
                // Should set result.Success true when _hashProvider.Hash(args.Password) equals user.Password

                throw new NotImplementedException();
            }

            return result;
        }
    }

    public class LoginAuthenticateRequestArgs
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class LoginAuthenticateResult
    {
        public bool Success { get; set; }
    }
}
