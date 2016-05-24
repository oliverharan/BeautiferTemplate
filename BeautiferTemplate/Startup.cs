using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeautiferTemplate.Startup))]
namespace BeautiferTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
