using Microsoft.Extensions.Logging;
using Moq;
using System;


namespace MsCommun.Utils
{
    public static class LogHelpers
    {
        private static System.Linq.Expressions.Expression<Action<ILogger<T>>> Verify<T>(LogLevel level)
        {
            return (ILogger<T> x) => x.Log(It.Is((LogLevel l) => (int)l == (int)level), It.IsAny<EventId>(), It.Is<It.IsAnyType>((object v, Type t) => true), It.IsAny<Exception>(), It.Is<Func<It.IsAnyType, Exception, string>>((object v, Type t) => true));
        }

        private static void CustomVerify<T>(this Mock<ILogger<T>> mock, LogLevel level, Times times)
        {
            mock.Verify(Verify<T>(level), times);
        }
    }
      
}
