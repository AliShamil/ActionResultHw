using System.Net;
using System.Text;

namespace MyMiddleWebServer.ActionResults;
public class ContentResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        var bytes = Encoding.UTF8.GetBytes("Content Result Example");
        context.Response.ContentType = "text/plain";
        context.Response.OutputStream.Write(bytes);
    }
}
