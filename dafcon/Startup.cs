using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dafcon.Startup))]
namespace dafcon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
