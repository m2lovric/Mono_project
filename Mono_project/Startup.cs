using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mono_project.Startup))]
namespace Mono_project
{
    interface IVehicle
    {
        int Id { get; set; }       
        string Name { get; set; }
        string Abrv { get; set; }
    }
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
