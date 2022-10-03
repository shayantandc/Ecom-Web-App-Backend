﻿namespace Category.Logger
{
    public interface IloggerService
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
        void LogTrace(string message);
    }
}
