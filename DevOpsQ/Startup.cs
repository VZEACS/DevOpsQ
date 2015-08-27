using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsQ.Startup))]
namespace DevOpsQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
