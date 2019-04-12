using ApplicationCore.Application.Claims;
using ApplicationCore.Application.Interfaces.Claims;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PhoneClaimsFunctionApp;

[assembly: WebJobsStartup(typeof(Startup))]
namespace PhoneClaimsFunctionApp
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddScoped<IPhoneClaimsManager, PhoneClaimsManager>();
        }    
    }
}
