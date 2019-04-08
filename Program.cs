using System;
using Grpc.Core;
using trajectoryClient.lib.Services;

namespace trajectoryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientServices.RunClientService();
        }
    }
}
