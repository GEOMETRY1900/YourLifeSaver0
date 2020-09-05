using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourLifeSaver.Startup))]
namespace YourLifeSaver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
