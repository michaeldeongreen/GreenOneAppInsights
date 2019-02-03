using System;

namespace GreenOne.Services.interfaces
{
    public interface ILogger
    {
        void LogError(Exception ex);
    }
}