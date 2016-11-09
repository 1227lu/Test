using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuciferFirstDemo.Startup))]
namespace LuciferFirstDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
