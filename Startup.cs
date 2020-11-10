using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependenceAjax.Startup))]
namespace DependenceAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
