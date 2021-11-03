using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;

using R5T.T0064;


namespace R5T.D0091
{
    [ServiceDefinitionMarker]
    public interface IApplicationConfigurer : IServiceDefinition
    {
        Task ConfigureApplication(IApplicationBuilder applicationBuilder);
    }
}