using IMustafa.Web;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var client = new HttpClientPlus(new MyConfig()))
            {
                client.SetContentType(ContentType.Application_Json);
                client.BaseAddress = new Uri("https://google.com");
                var rrr = client.GetAsync("https://google.com").Result;

            }

            Console.ReadLine();

        }
    }

    public class MyConfig : HttpClientPlusOption
    {
        public override Task AfterExecuteAsync()
        {
            Console.WriteLine("after");

            return base.AfterExecuteAsync();
        }

        public override Task BeforeExecuteAsync()
        {
            Console.WriteLine("before");

            return base.BeforeExecuteAsync();
        }

        public override Task FinalAsync()
        {
            Console.WriteLine("Final");

            return base.FinalAsync();
        }
    }
}
