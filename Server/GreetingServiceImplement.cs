using Greet;
using Grpc.Core;
using static Greet.GreetingService;

namespace Server
{
    public class GreetingServiceImplement : GreetingServiceBase
    {
        public override Task<GreetingResponse> Greet(GreetingRequest request, ServerCallContext context)
        {
            string result = $"Hello {request.Greeting.FirstName} {request.Greeting.LastName}";

            return Task.FromResult(new GreetingResponse
            {
                Result = result
            });
        }
    }
}
