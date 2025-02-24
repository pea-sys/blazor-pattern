﻿using System.Collections.Concurrent;

namespace BlazorApp
{
    public class ExceptionFileLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, ExceptionFileLogger> _loggers = new ConcurrentDictionary<string, ExceptionFileLogger>();

        public ExceptionFileLoggerProvider()
        {
            // initialization code
        }

        public ILogger CreateLogger(string categoryName)
        {
            var logger = _loggers.GetOrAdd(categoryName, new ExceptionFileLogger());
            return logger;
        }

        public void Dispose()
        {
            _loggers.Clear();
        }
    }

}
