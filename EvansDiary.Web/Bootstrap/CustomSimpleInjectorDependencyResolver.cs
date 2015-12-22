using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;

using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace EvansDiary.Web.Bootstrap
{
    //[SecuritySafeCritical]
    public class CustomSimpleInjectorDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInjectorDependencyResolver"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="container"/> is a null
        /// reference.</exception>
        public CustomSimpleInjectorDependencyResolver(Container container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            Container = container;
        }

        /// <summary>Gets the container.</summary>
        /// <value>The <see cref="Container"/>.</value>
        public Container Container { get; private set; }

        private IServiceProvider ServiceProvider
        {
            get
            {
                return Container;
            }
        }

        /// <summary>Resolves singly registered services that support arbitrary object creation.</summary>
        /// <param name="serviceType">The type of the requested service or object.</param>
        /// <returns>The requested service or object.</returns>
        public object GetService(Type serviceType)
        {
            // By calling GetInstance instead of GetService when resolving a controller, we prevent the
            // container from returning null when the controller isn't registered explicitly and can't be
            // created because of an configuration error. GetInstance will throw a descriptive exception
            // instead. Not doing this will cause MVC to throw a non-descriptive "Make sure that the 
            // controller has a parameterless public constructor" exception.
            if (!serviceType.IsAbstract && typeof(IController).IsAssignableFrom(serviceType))
            {
                return Container.GetInstance(serviceType);
            }

            return ServiceProvider.GetService(serviceType);
        }

        /// <summary>Resolves multiply registered services.</summary>
        /// <param name="serviceType">The type of the requested services.</param>
        /// <returns>The requested services.</returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            Type collectionType = typeof(IEnumerable<>).MakeGenericType(serviceType);

            var services = (IEnumerable<object>)ServiceProvider.GetService(collectionType);

            return services ?? Enumerable.Empty<object>();
        }
    }
}
