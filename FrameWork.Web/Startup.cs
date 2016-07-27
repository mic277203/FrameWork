using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrameWork.Web.Startup))]
namespace FrameWork.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
