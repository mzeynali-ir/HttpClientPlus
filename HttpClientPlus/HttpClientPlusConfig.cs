using System.Net.Http;
using System.Threading.Tasks;

namespace IMustafa
{
    public class HttpClientPlusConfig
    {
        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;
        public virtual Task AfterExecuteAsync(HttpResponseMessage response) => Task.CompletedTask;
        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;
        public virtual Task FinalAsync() => Task.CompletedTask;
    }
}

