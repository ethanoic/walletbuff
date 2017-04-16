using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WalletBuffApp.Startup))]
namespace WalletBuffApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
