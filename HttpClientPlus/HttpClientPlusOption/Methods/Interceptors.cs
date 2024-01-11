using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlusOption
    {
        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;
        public virtual Task AfterExecuteAsync<TResponse>(TResponse response) => Task.CompletedTask;
        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;
        public virtual Task FinalAsync() => Task.CompletedTask;
    }
}