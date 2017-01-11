using Grpc.Core;
using Inman.Platform.ServiceStub;
using System;

class Program
{
    static void Main(string[] args)
    {
        Channel channel = new Channel("192.168.7.213:50052", ChannelCredentials.Insecure);

        var client = new UserService.UserServiceClient(channel);
        //String user = "you";

        var reply =  client.LoginValidate(new LoginStuff { UserName = "hurong", Password= "vcCArGsDhKHRTS9Hp0Eonw0VtMiyXmCZgI+s+NiXzVg=" });
        Console.WriteLine("LoginResult: " + reply.Success);
        Console.WriteLine("User: " + reply.User);

        channel.ShutdownAsync().Wait();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}