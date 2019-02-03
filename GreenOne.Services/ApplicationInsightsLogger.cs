using System;
using GreenOne.Services.interfaces;
using Microsoft.ApplicationInsights;

namespace GreenOne.Services
{
    public class ApplicationInsightsLogger : ILogger
    {
        private readonly TelemetryClient _client;
        public ApplicationInsightsLogger(TelemetryClient client)
        {
            _client = client;
        }

        public void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}