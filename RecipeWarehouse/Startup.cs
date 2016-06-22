using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeWarehouse.Startup))]
namespace RecipeWarehouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
