using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentVDB.Startup))]
namespace RentVDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
