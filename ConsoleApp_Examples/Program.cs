using IMustafa.Web;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm HttpClientPlus. I Improve HttpClient Microsoft.");

            while (true)
            {
                using (var client = new HttpClientPlus(new MyConfig()))
                {
                    client.AddBearerAuthentication("");
                    client.SetContentType(ContentType.Application_Json);
                    client.BaseAddress = new Uri("https://google.com");
                    var rrr = client.GetAsync("https://google.com").Result;
                }

                Console.ReadLine();
            }
        }
    }

    public class MyConfig : HttpClientPlusOption
    {

        public override Task AfterExecuteAsync()
        {
            Console.WriteLine("after call api.");

            return base.AfterExecuteAsync();
        }

        public override Task AfterExecuteAsync(HttpResponseMessage response)
        {
            Console.WriteLine("after call api.");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("response is success :)");
            }
            else
            {
                Console.WriteLine("response is failure :(");
            }

            return base.AfterExecuteAsync(response);
        }

        public override Task BeforeExecuteAsync()
        {
            //set bearer authorization to all request just once!
            this.SetDefaultAuthorization(AuthorizationType.Bearer("token"));

            Console.WriteLine("before call api.");

            return base.BeforeExecuteAsync();
        }

        public override Task FinallyAsync()
        {
            Console.WriteLine("Finally.");

            return base.FinallyAsync();
        }

    }
}
