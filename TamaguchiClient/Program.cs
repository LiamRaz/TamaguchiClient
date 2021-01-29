using System;
using TamaguchiClient.WebServices;
using System.Threading.Tasks;

namespace TamaguchiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("https://localhost:44387/api/Tamaguchi");
            Task<string> t = c.Lucas();
            t.Wait();
            Console.WriteLine(t.Result);
        }
    }
}
