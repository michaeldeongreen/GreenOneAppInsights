using GreenOne.Services.interfaces;
using Lamar;
using Microsoft.ApplicationInsights;

namespace GreenOne.Web.IoC
{
    public class ServicesRegistry : ServiceRegistry
    {
        public ServicesRegistry()
        {
            Scan(s =>{
                s.AssemblyContainingType<ILogger>();
                s.WithDefaultConventions();
                s.AddAllTypesOf<ILogger>();
            });

            For<TelemetryClient>().Use<TelemetryClient>();
        }
    }
}