
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using Smooth.IoC.Repository.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;
using Autofac;
using NorthWind.API.Repositories;
using NorthWind.API.Helpers;
using NorthWind.API.Attributes;

namespace NorthWind.API
{
    public class AutofacRegistrar
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.Register(c => new AutofacDbFactory(c.Resolve<IComponentContext>())).As<IDbFactory>().SingleInstance();
            builder.RegisterType<Smooth.IoC.UnitOfWork.UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<AppSession>().As<IAppSession>();
            builder.RegisterGeneric(typeof(Repository<,>)).AsSelf();

            var dataAccess = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(AssemblyHelper.GetReferencingAssemblies("NorthWind.API").ToArray()).AsClosedTypesOf(typeof(IRepository<,>));
            //
            builder.Register(o => o.ResolveNamed<string>("ServiceUrls:IdentityServiceUrl")).Named<string>("identityServiceUrl");
        }

        [NoIoCFluentRegistration]
        sealed class AutofacDbFactory : IDbFactory
        {
            private readonly IComponentContext _container;
            public AutofacDbFactory(IComponentContext container)
            {
                _container = container;
            }
            public T Create<T>() where T : class, ISession
            {
                return _container.Resolve<T>();
            }
            public TUnitOfWork Create<TUnitOfWork, TSession>(IsolationLevel isolationLevel = IsolationLevel.Serializable) where TUnitOfWork : class, IUnitOfWork where TSession : class, ISession
            {
                return _container.Resolve<TUnitOfWork>(new NamedParameter("factory", _container.Resolve<IDbFactory>()),
                    new NamedParameter("session", Create<TSession>()), new NamedParameter("isolationLevel", isolationLevel)
                    , new NamedParameter("sessionOnlyForThisUnitOfWork", true));
            }
            public T Create<T>(IDbFactory factory, ISession session, IsolationLevel isolationLevel = IsolationLevel.Serializable) where T : class, IUnitOfWork
            {
                return _container.Resolve<T>(new NamedParameter("factory", factory),
                    new NamedParameter("session", session), new NamedParameter("isolationLevel", isolationLevel));
            }
            public void Release(IDisposable instance)
            {
                instance.Dispose();
            }
        }
    }
}