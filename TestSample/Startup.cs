using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSample.Startup))]
namespace TestSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
