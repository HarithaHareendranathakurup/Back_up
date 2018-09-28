using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleProgram.Startup))]
namespace SampleProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
