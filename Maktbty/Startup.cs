using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maktbty.Startup))]
namespace Maktbty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
