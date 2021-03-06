﻿using System.Reflection;
using System.Web;
using System.Web.Mvc;

using EvansDiary.Interfaces;
using EvansDiary.Web.Diary.StaticContent;

using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace EvansDiary.Web.Bootstrap
{
    public static class Bootstrap
    {
        public static Container InitBootstrap(this HttpApplication httpApplication)
        {
            var container = new Container();

            container.RegisterSingleton<IStaticContentDelivery, StaticContentDelivery>();
            container.RegisterSingleton<IStaticHospitalContentDelivery, StaticHospitalContentDelivery>();

            ConfigureContainerIntegration(container);

            return container;
        }

        private static void ConfigureContainerIntegration(Container container)
        {
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.RegisterMvcIntegratedFilterProvider();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
