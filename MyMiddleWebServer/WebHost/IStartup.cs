using MyMiddleWebServer.Middlewares;

namespace MyMiddleWebServer.WebHost;

public interface IStartup
{
    public void Configure(MiddlewareBuilder builder);
}
