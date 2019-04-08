using System;
using System.IO;
using System.Threading.Tasks;
using ApplicationCore.Application.Claims;
using ApplicationCore.Application.Interfaces.Claims;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace PhoneClaimsFunctionApp
{
    public class BlobTriggeredInboundPhoneClaimFunction
    {
        private readonly IPhoneClaimsManager _phoneClaimsManager;

        public BlobTriggeredInboundPhoneClaimFunction(IPhoneClaimsManager phoneClaimsManager)
        {
            _phoneClaimsManager = phoneClaimsManager;
        }


        [FunctionName("BlobTriggeredInboundPhoneClaimFunction")]
        public async Task Run([BlobTrigger("inbound-phone-claims/{name}", Connection = "StorageConnectionSettings")]Stream myBlob, 
            string name, 
            ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            try
            {
                var processed = await _phoneClaimsManager.ManageClaimAsync(new PhoneClaimModel(name, myBlob));

                if (processed)
                {
                    log.LogInformation($"Successfully processed {name}");
                }
                else
                {
                    log.LogWarning($"Failed to process {name}");
                }         
            }
            catch (Exception e)
            {
                log.LogError(e.Message, e);
                throw;
            }
        }



    }
}
