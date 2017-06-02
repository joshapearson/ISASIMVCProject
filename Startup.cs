using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISASIMVCProject.Startup))]
namespace ISASIMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
