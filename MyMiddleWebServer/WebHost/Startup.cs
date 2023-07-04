using MyMiddleWebServer.Middlewares;

namespace MyMiddleWebServer.WebHost;

public class Startup : IStartup
{
    public void Configure(MiddlewareBuilder builder)
    {
        builder.Use<LoggerMiddleware>();
        builder.Use<StaticFileMiddleware>();
        builder.Use<MvcMiddleware>();
    }
}
