using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvansDiary.Web.Startup))]
namespace EvansDiary.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
