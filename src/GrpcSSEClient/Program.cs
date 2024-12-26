using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcSSEClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EventService.EventServiceClient(channel);

            var request = new SubscribeRequest { ClientId = "client1" };

            using var call = client.Subscribe(request);

            try
            {
                await foreach (var response in call.ResponseStream.ReadAllAsync())
                {
                    Console.WriteLine($"Received: {response.EventData}");
                }
            }
            catch (RpcException e) when (e.StatusCode == Grpc.Core.StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled.");
            }
        }
    }
}
