using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentRecordApp.Web.Startup))]
namespace StudentRecordApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
