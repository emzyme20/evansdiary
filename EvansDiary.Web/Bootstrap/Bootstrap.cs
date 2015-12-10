using System.Web;

using EvansDiary.Web.Diary;
using EvansDiary.Web.Interfaces;

using SimpleInjector;

namespace EvansDiary.Web.Bootstrap
{
    public static class Bootstrap
    {
        public static Container InitBootstrap(this HttpApplication httpApplication)
        {
            var container = new Container();
            
            container.RegisterSingleton<IStaticContentDelivery, StaticContentDelivery>();
            
            return container;
        }
    }
}