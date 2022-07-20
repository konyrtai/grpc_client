// создаем канал для обмена сообщениями с сервером
// параметр - адрес сервера gRPC

using Grpc.Net.Client;
using SimpleGrpcService;

using var channel = GrpcChannel.ForAddress("http://localhost:5016");
// создаем клиента
var client = new Greeter.GreeterClient(channel);
Console.Write("Введите имя: ");
string name = Console.ReadLine();
// обмениваемся сообщениями с сервером
var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine("Ответ сервера: " + reply.Message);
Console.ReadKey();