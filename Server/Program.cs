using Greet;
using Grpc.Core;
using Server;

const int port = 50051;

Grpc.Core.Server server = null; // Use the fully qualified name

try
{
    server = new Grpc.Core.Server // Use the fully qualified name
    {
        Services = { GreetingService.BindService(new GreetingServiceImplement()) },
        Ports = { new ServerPort("localhost", port, ServerCredentials.Insecure) }
    };

    server.Start();
    Console.WriteLine($"Server is listening on port {port}");
    Console.ReadKey();
}
catch (Exception e)
{
    Console.WriteLine($"Server failed to start: {e.Message}");
}
finally
{
    if (server != null)
    {
        await server.ShutdownAsync();
    }
}
