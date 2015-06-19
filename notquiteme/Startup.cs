using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(notquiteme.Startup))]
namespace notquiteme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
