using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using Unity;
using Unity.Exceptions;

namespace SREWT
{
    public class UnityApiActivator : IDependencyResolver
    {
        /// <summary>
        /// Unity conatiner instance.
        /// </summary>
        protected Unity.IUnityContainer _container;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="container"></param>
        public UnityApiActivator(Unity.IUnityContainer container)
        {
            this._container = container ?? throw new ArgumentNullException("container");
        }

        /// <summary>
        /// Returns service instance of desired type.
        /// </summary>
        /// <param name="serviceType">Type of the desired service.</param>
        /// <param name="name">Name of the desired service.</param>
        /// <returns></returns>
        public object GetService(Type serviceType, string name)
        {
            try
            {
                if (_container.IsRegistered(serviceType, name))
                {
                    return _container.Resolve(serviceType, name);
                }
                else
                {
                    return null;
                }
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns service instance of desired type.
        /// </summary>
        /// <param name="serviceType">Type of the desired service.</param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            try
            {
                if (_container.IsRegistered(serviceType, serviceType.Name))
                {
                    return _container.Resolve(serviceType, serviceType.Name);
                }
                else
                {
                    return null;
                }
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns service instances of desired type.
        /// </summary>
        /// <param name="serviceType">Type of the desired service.</param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType, null);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityApiActivator(child);
        }

        /// <summary>
        /// Disposes container.
        /// </summary>
        public void Dispose()
        {
            _container.Dispose();
        }
    }

    public class HttpControllerActivator : IHttpControllerActivator
    {
        private IUnityContainer _container;
        public HttpControllerActivator(IUnityContainer container)
        {
            _container = container;
        }
        public IHttpController Create(HttpControllerContext controllerContext, Type controllerType)
        {
            return (IHttpController)_container.Resolve(controllerType);
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return (IHttpController)_container.Resolve(controllerType);
        }
    }
}