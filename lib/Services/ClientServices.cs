
using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrajectoryServer;

namespace trajectoryClient.lib.Services
{
    public class ClientServices
    {
        public static void RunClientService()
        {
            Console.WriteLine($"trajectory server : {Environment.GetEnvironmentVariable("TrajectoryServer")}");
            var channel = new Channel("0.0.0.0:50041", ChannelCredentials.Insecure);
            var client = new DroneService.DroneServiceClient(channel);
            // https://stackoverflow.com/questions/45547278/how-to-wait-for-the-grpc-server-connection
            var reply = client.SendRequest(new Request {  Name ="5678ABCD" }, new CallOptions().WithWaitForReady(true));
            Console.WriteLine("Hello world .....: " + reply.Message);
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}