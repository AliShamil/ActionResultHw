using MyMiddleWebServer.ActionResults;
using System.Net;

namespace MyMiddleWebServer.Controllers
{
    public abstract class Controller
    {
        public HttpListenerContext Context { get; set; }

        public ViewResult View()
        {
            var result = new ViewResult();
            result.ExecuteResult(Context);
            return result;
        }

        public ContentResult ContentEx()
        {
            var result = new ContentResult();
            result.ExecuteResult(Context);
            return result;
        }

        public JsonResult JsonEx()
        {
            var result = new JsonResult();
            result.ExecuteResult(Context);
            return result;
        }

        public EmptyResult EmptyEx()
        {
            var result = new EmptyResult();
            result.ExecuteResult(Context);
            return result;
        }

        public FileResult FileEx()
        {
            var result = new FileResult();
            result.ExecuteResult(Context);
            return result;
        }

        public RedirectResult RedirectEx()
        {
            var result = new RedirectResult();
            result.ExecuteResult(Context);
            return result;
        }
    }
}
