using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitTreeMarket.Startup))]
namespace BitTreeMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
