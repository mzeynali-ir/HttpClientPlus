using System.Net.Http;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption
    {

        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;

        /// <summary>
        /// TIP: this method not calling in put, post, delete, path !!!
        /// </summary>
        public virtual Task AfterExecuteAsync() => Task.CompletedTask;

        /// <summary>
        /// TIP: this method just calling in put, post, delete, path
        /// </summary>
        public virtual Task AfterExecuteAsync(HttpResponseMessage response) => Task.CompletedTask;

        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;

        public virtual Task FinalAsync() => Task.CompletedTask;

    }
}