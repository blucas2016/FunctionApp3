using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Azure.Messaging.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp3
{
    public static class Function1
    {
        

        [FunctionName("Function1")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "ConnectionStrings:Conn")]string message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {(message)}");
        }
    }
}