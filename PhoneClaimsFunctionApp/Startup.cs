using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using PhoneClaimsFunctionApp;

[assembly: WebJobsStartup(typeof(Startup))]
namespace PhoneClaimsFunctionApp
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            throw new NotImplementedException();
        }



    }
}
