using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalBlog.Startup))]
namespace PersonalBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
