using FluentAssertions;
using Moq;
using NSubstitute;

namespace ConsoleApp1.Test
{
    public class LoginServiceTest
    {
        private readonly IUserRepository _userRepository;
        private readonly IHashProvider _hashProvider;

        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly Mock<IHashProvider> _hashProviderMock;

        private LoginService _sut;

        public LoginServiceTest()
        {
            _userRepository = Substitute.For<IUserRepository>();
            _hashProvider = Substitute.For<IHashProvider>();

            _userRepositoryMock = new Mock<IUserRepository>();
            _hashProviderMock = new Mock<IHashProvider>();

            _sut = new LoginService();
        }

        [Fact]
        public async Task AuthenticateAsync_ShouldReturnTrue()
        {
            // Arrange
            LoginAuthenticateRequestArgs args = new();

            // Act
            var result = await _sut.AuthenticateAsync(args);

            // Assert
            //TO-DO: verify result
        }

        [Fact]
        public async Task AuthenticateAsync_ShouldReturnFalse()
        {
            // Arrange
            LoginAuthenticateRequestArgs args = new();

            // Act
            var result = await _sut.AuthenticateAsync(args);

            // Assert
            //TO-DO: verify result
        }
    }
}