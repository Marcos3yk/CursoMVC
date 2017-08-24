using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MV.CursoMvc.UI.MVC.Startup))]
namespace MV.CursoMvc.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
