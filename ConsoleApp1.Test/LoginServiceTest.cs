using FluentAssertions;
using NSubstitute;

namespace ConsoleApp1.Test
{
    public class LoginServiceTest
    {
        private IUserRepository _userRepository;
        private IHashProvider _hashProvider;

        private LoginService _sut;

        public LoginServiceTest()
        {
            _userRepository = Substitute.For<IUserRepository>();
            _hashProvider = Substitute.For<IHashProvider>();

            _sut = new LoginService();
        }

        [Fact]
        public async Task AuthenticateAsync_ShouldReturnTrue()
        {
            // Arrange
            LoginAuthenticateRequestArgs args = new();

            // Act
            var result = _sut.AuthenticateAsync(args);

            // Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task AuthenticateAsync_ShouldReturnFalse()
        {
            // Arrange
            LoginAuthenticateRequestArgs args = new();

            // Act
            var result = _sut.AuthenticateAsync(args);

            // Assert
            result.Should().NotBeNull();
        }
    }
}