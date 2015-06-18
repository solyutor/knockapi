using System.Web.Http;
using Owin;

namespace KnockApi
{
    public class OwinBootstrapper
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(new HttpConfiguration());
        }
    }
}