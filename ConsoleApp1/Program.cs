// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
    })
    .Build();

T? GetService<T>() => host!.Services.GetService<T>();

ILoginService loginService = new LoginService();

var request = new LoginAuthenticateRequestArgs
{
    Username = "spam",
    Password = "eggs",
};

var result = await loginService.AuthenticateAsync(request);

Console.WriteLine($"success: {result.Success}");
