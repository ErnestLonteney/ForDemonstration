using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Tests.Fixtures
{
    public abstract class TestFixtureBase
    {
        protected MyCRMContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<MyCRMContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new MyCRMContext(options);
        }

        protected ILogger<T> GetMockLogger<T>()
        {
            return new MockLogger<T>();
        }
    }

    public class MockLogger<T> : ILogger<T>
    {
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;
        public bool IsEnabled(LogLevel logLevel) => false;
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) where TState : notnull { }
    }
}
