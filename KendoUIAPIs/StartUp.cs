using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(KendoUIAPIs.StartUp))]
namespace KendoUIAPIs
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}