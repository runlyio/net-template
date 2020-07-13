using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MyJob.Tests
{
	public class FakeLogger<T> : ILogger<T>
	{
		public List<string> Logs { get; } = new List<string>();

		public IDisposable BeginScope<TState>(TState state) => new FakeDisposer();
		class FakeDisposer : IDisposable { public void Dispose() { } }

		public bool IsEnabled(LogLevel logLevel) => false;
		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			Logs.Add(formatter(state, exception));
		}
	}
}
