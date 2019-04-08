using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace PhoneClaimsFunctionApp
{
    public static class BlobTriggeredInboundPhoneClaimFunction
    {
        [FunctionName("BlobTriggeredInboundPhoneClaimFunction")]
        public static void Run([BlobTrigger("inbound-phone-claims/{name}", Connection = "StorageConnectionSettings")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }



    }
}
