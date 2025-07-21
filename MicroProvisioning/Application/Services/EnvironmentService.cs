using MicroProvisioning.Application.Interfaces;

namespace MicroProvisioning.Application.Services
{
    public class EnvironmentService : IEnvironmentService
    {
        public string GetVariable(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

    }
}
