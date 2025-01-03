using Grpc.Core;

const int port = 50051;

Server server = null;

try
{
    server = new Server
    {
        Services = { },
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
