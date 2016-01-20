using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace HY.Common.Autofac
{
    public class AutofacObjectContainer : IObjectContainer
    {
        private readonly IContainer _container;

        public AutofacObjectContainer()
        {
            _container = new ContainerBuilder().Build();
        }

        public AutofacObjectContainer(ContainerBuilder containerBuilder)
        {
            _container = containerBuilder.Build();
        }

        public IContainer Container
        {
            get
            {
                return _container;
            }
        }

        public void RegisterType(Type implementationType, LifeStyle life = LifeStyle.Singleton)
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType(implementationType);
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            builder.Update(_container);
        }
       
        public void RegisterType(Type serviceType, Type implementationType, LifeStyle life = LifeStyle.Singleton)
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType(implementationType).As(serviceType);
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            else if (life == LifeStyle.InstancePerLifetimeScope)
            {
                registrationBuilder.InstancePerLifetimeScope();
            }
            builder.Update(_container);
        }
       
        public void Register<TService, TImplementer>(LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType<TImplementer>().As<TService>();
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            else if (life == LifeStyle.InstancePerLifetimeScope)
            {
                registrationBuilder.InstancePerLifetimeScope();
            }

            builder.Update(_container);
        }
       
        public void RegisterInstance<TService, TImplementer>(TImplementer instance)
            where TService : class
            where TImplementer : class, TService
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(instance).As<TService>().SingleInstance();
            builder.Update(_container);
        }
       
        public TService Resolve<TService>() where TService : class
        {
            return _container.Resolve<TService>();
        }
        
        public object Resolve(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public TService Resolve<TService>(Type type, object param) where TService : class
        {
            return _container.Resolve<TService>(new TypedParameter(type, param));
        }

        public TService Resolve<TService>(string name, object param) where TService : class
        {
            return _container.Resolve<TService>(new NamedParameter(name, param));
        }


        public void Register<TService, TImplementer>(string name, LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType<TImplementer>().Named<TService>(name);
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            else if (life == LifeStyle.InstancePerLifetimeScope)
            {
                registrationBuilder.InstancePerLifetimeScope();
            }

            builder.Update(_container);
        }

        public void RegisterType(Type serviceType, Type implementationType, string name, LifeStyle life = LifeStyle.Singleton)
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType(implementationType).Named(name, serviceType);
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            else if (life == LifeStyle.InstancePerLifetimeScope)
            {
                registrationBuilder.InstancePerLifetimeScope();
            }
            builder.Update(_container);
        }

        public TService Resolve<TService>(string name) where TService : class
        {
            return _container.ResolveNamed<TService>(name);
        }

        public object Resolve(string name, Type serviceType)
        {
            return _container.ResolveNamed(name, serviceType);
        }
       
        public void Register<TImplementer>(LifeStyle life = LifeStyle.Singleton) where TImplementer : class
        {
            var builder = new ContainerBuilder();
            var registrationBuilder = builder.RegisterType<TImplementer>();
            if (life == LifeStyle.Singleton)
            {
                registrationBuilder.SingleInstance();
            }
            else if (life == LifeStyle.InstancePerLifetimeScope)
            {
                registrationBuilder.InstancePerLifetimeScope();
            }

            builder.Update(_container);
        }
    }
}
