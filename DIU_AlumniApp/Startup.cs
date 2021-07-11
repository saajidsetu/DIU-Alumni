using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DIU_AlumniApp.Startup))]
namespace DIU_AlumniApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
