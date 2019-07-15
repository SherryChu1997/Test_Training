using System;

namespace ServerApiDependency.Utility
{
    public interface ILogger
    {
    }

    public class Logger : ILogger
    {
        public static void Error(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class TiDebugHelper
    {
    }
}