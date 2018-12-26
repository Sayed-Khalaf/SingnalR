using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_WebMvcHub.Startup))]
namespace SignalR_WebMvcHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
