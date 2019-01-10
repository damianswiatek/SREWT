using System;
using System.Web.Http.Dispatcher;
using BusinessLogic;
using BusinessLogic.Services;
using BusinessLogic.Services.StoredProcedures;
using DataModel.Container;
using DataModel.Entities;
using DataModel.Repository;
using DataModel.Repository.Interfaces;
using Microsoft.Practices.Unity;
using SREWT.JWT;
using SREWT.JWT.Provider;
using SREWT.JWT.Provider.Interfaces;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Lifetime;

namespace SREWT
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        public static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();


            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<System.Data.Entity.DbContext, DatabaseContainer>(new PerRequestLifetimeManager());

            // Unit of Work
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerRequestLifetimeManager());

            // Password Hasher
            container.RegisterType<IAuthService, AuthService>(new HierarchicalLifetimeManager());
            container.RegisterType<IMembershipHashProvider, MembershipHashProvider>(new PerRequestLifetimeManager());
            container.RegisterType<IMembershipProvider, MembershipProvider>(new PerRequestLifetimeManager());
            container.RegisterType<IRSAKeyProvider, RSAKeyProvider>(new PerRequestLifetimeManager());

            // JWT Token Provider
            container.RegisterType<IJwtTokenProvider, JwtTokenProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<IIdentityProvider, IdentityProvider>(new PerRequestLifetimeManager());

            // Repositories
            container.RegisterType<IBaseRepository<User>, BaseRepository<User>>(new PerRequestLifetimeManager());
            container.RegisterType<IRepository<User>, GenericRepository<User>>(new PerRequestLifetimeManager());
            container.RegisterType<IRepository<Address>, GenericRepository<Address>>(new PerRequestLifetimeManager());

            // Services
            container.RegisterType<IUsersService, UsersService>(new PerRequestLifetimeManager());
            container.RegisterType<IUserServiceSQL, UserServiceSQL>(new PerRequestLifetimeManager());
        }
    }
}
