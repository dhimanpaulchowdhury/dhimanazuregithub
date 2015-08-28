using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureGitHubDemoWebApp.Startup))]
namespace AzureGitHubDemoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
