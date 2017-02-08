using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mono_project.Startup))]
namespace Mono_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
