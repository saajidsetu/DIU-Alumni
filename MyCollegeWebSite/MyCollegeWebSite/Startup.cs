using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCollegeWebSite.Startup))]
namespace MyCollegeWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
