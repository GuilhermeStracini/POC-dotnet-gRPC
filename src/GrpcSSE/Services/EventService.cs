using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcSSE.Services
{
    public class EventService : EventService.EventServiceBase
    {
        public override async Task Subscribe(
            SubscribeRequest request,
            IServerStreamWriter<EventResponse> responseStream,
            ServerCallContext context
        )
        {
            // Simulate event streaming
            for (int i = 0; i < 10; i++)
            {
                if (context.CancellationToken.IsCancellationRequested)
                {
                    break;
                }

                var eventData = new EventResponse
                {
                    EventData = $"Event {i} for client {request.ClientId}",
                };
                await responseStream.WriteAsync(eventData);
                await Task.Delay(1000); // Simulate delay between events
            }
        }
    }
}
