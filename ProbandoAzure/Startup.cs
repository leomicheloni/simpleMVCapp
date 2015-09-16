using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProbandoAzure.Startup))]
namespace ProbandoAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
