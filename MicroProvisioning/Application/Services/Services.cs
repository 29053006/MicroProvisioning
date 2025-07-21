using MicroProvisioning.Application.Interfaces;

namespace MicroProvisioning.Application.Services
{
    public class Services(IRepositories _repositories,
                          IEnvironmentService _environmentServices) : IServices
    {

        public Task<bool> GetServicesAsync()
        {
            _environmentServices.GetVariable("prueba");
            return Task.FromResult(true);
        }
    }
}
