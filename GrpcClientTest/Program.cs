using System;
using Grpc.Core;
using Morai.Proto;

namespace ClientTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            // morai bridge client test
            Channel channel = new Channel("127.0.0.1:7789", ChannelCredentials.Insecure);
            var client = new MoraiService.MoraiServiceClient(channel);

            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1)
                {
                    CreateVehicleParam param = new CreateVehicleParam()
                    {
                        Name = "Genesis",
                    };
                    var res = client.CreateVehicle(param);
                    Console.WriteLine($"")
                }
                else if (cki.Key == ConsoleKey.D2)
                {
                }
                else if (cki.Key == ConsoleKey.D3)
                {
                }
            } while (cki.Key != ConsoleKey.Escape);

            // program end
        }
    }
}
