using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactProject.Startup))]
namespace ContactProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
