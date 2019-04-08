
using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrajectoryServer;
using static TrajectoryServer.DroneService;

namespace trajectoryClient.lib.Services
{
    public class ClientServices
    {
        public static void RunClientService()
        {
            Channel channel = null;
            try
            {
                Console.WriteLine($"trajectory server : {Environment.GetEnvironmentVariable("TrajectoryServer")}");
                channel = new Channel("0.0.0.0:50041", ChannelCredentials.Insecure);
                var client = new DroneServiceClient(channel);
                // https://stackoverflow.com/questions/45547278/how-to-wait-for-the-grpc-server-connection
                var request = new TrajectoryServer.Request { Name = "5678ABCD" };
                SendRequest(client, request).Wait();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                channel.ShutdownAsync().Wait();
                Console.WriteLine($"An error occur, Server is shutdown with an error of {e.ToString()}");
            }
        }

        private static async Task SendRequest(DroneServiceClient client, TrajectoryServer.Request request)
        {
            await Task.Run(() =>
            {
                client.SendRequestAsync(request, new CallOptions().WithWaitForReady(true));
                Console.WriteLine("running...");
            });
        }
    }
}