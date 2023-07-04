using System.Net;

namespace MyMiddleWebServer.ActionResults;
public class FileResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {   
        string filePath = Path.GetFullPath( @$"..\..\..\StaticFiles\Capybara.jpg");
        Console.WriteLine(filePath);
        context.Response.ContentType = "image/jpeg";
        var bytes = File.ReadAllBytes(filePath);
        context.Response.OutputStream.Write(bytes);
    }
}
