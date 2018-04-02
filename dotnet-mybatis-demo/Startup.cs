using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotnet_mybatis_demo.Startup))]
namespace dotnet_mybatis_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
