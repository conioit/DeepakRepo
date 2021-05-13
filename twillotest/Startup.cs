using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(twillotest.Startup))]
namespace twillotest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
