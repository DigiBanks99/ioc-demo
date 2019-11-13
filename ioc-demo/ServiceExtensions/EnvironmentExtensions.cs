using System;
using Microsoft.AspNetCore.Hosting;

namespace IocDemo.ServiceExtensions
{
    public static class EnvironmentExtensions
    {
        public static bool IsBreak(this IWebHostEnvironment env)
        {
            return env.EnvironmentName.Equals("break", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
