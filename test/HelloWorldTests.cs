using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Runly.Testing;
using System.Threading.Tasks;
using Xunit;

namespace MyJob.Tests
{
	public class HelloWorldTests
	{
		readonly TestHost<HelloWorld> host;
		readonly HelloWorldConfig config;

		public HelloWorldTests()
		{
			host = new TestHost<HelloWorld>(config = new HelloWorldConfig())
				.ConfigureServices(s =>
				{
					s.AddSingleton<ILogger<HelloWorld>, FakeLogger<HelloWorld>>();
				});
		}

		[Fact]
		public async Task Should_say_hello()
		{
			using var runner = host.BuildRunner();

			config.Names = new[] { "Rick", "Morty" };

			await runner.RunAsync();

			var logger = (FakeLogger<HelloWorld>)runner.Services.GetRequiredService<ILogger<HelloWorld>>();

			logger.Logs.Should().Contain("Hello, Rick");
			logger.Logs.Should().Contain("Hello, Morty");
		}
	}
}
