using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace HY.Common.Unity
{
    public class UnityObjectContainer : IObjectContainer
    {
        private readonly IUnityContainer _container;

        public UnityObjectContainer(IUnityContainer iUnityContainer)
        {
            _container = iUnityContainer;
        }

        public IUnityContainer Container
        {
            get
            {
                return _container;
            }
        }

        public void Register<TService, TImplementer>(LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType<TService, TImplementer>(new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType<TService, TImplementer>(new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType<TService, TImplementer>(new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType<TService, TImplementer>(new TransientLifetimeManager());
                    break;
            }
        }

        public void RegisterInstance<TService, TImplementer>(TImplementer instance)
            where TService : class
            where TImplementer : class, TService
        {

        }

        public void RegisterType(Type serviceType, Type implementationType, LifeStyle life = LifeStyle.Singleton)
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType(serviceType, implementationType, new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType(serviceType, implementationType, new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType(serviceType, implementationType, new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType(serviceType, implementationType, new TransientLifetimeManager());
                    break;
            }
        }

        public void RegisterType(Type implementationType, LifeStyle life = LifeStyle.Singleton)
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType(implementationType, new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType(implementationType, new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType(implementationType, new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType(implementationType, new TransientLifetimeManager());
                    break;
            }
        }

        public object Resolve(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public TService Resolve<TService>() where TService : class
        {
            return _container.Resolve<TService>();
        }


        public TService Resolve<TService>(string name, object param) where TService : class
        {
            //to do  扩展批量参数
            return _container.Resolve<TService>(new ParameterOverrides { { name, param } });
        }

        public TService Resolve<TService>(Type type, object param) where TService : class
        {
            throw new NotImplementedException();
        }

        public void Register<TService, TImplementer>(string name, LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType<TService, TImplementer>(name, new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType<TService, TImplementer>(name, new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType<TService, TImplementer>(name, new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType<TService, TImplementer>(name, new TransientLifetimeManager());
                    break;
            }

        }

        public void RegisterType(Type serviceType, Type implementationType, string name, LifeStyle life = LifeStyle.Singleton)
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType(serviceType, implementationType, name, new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType(serviceType, implementationType, name, new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType(serviceType, implementationType, name, new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType(serviceType, implementationType, name, new TransientLifetimeManager());
                    break;
            }
        }

        public object Resolve(string name, Type serviceType)
        {
            return _container.Resolve(serviceType, name);
        }

        public TService Resolve<TService>(string name) where TService : class
        {
            return _container.Resolve<TService>(name);
        }


        public void Register<TImplementer>(LifeStyle life = LifeStyle.Singleton) where TImplementer : class
        {
            switch (life)
            {
                case LifeStyle.InstancePerLifetimeScope:
                    _container.RegisterType<TImplementer>(new PerResolveLifetimeManager());
                    break;
                case LifeStyle.Singleton:
                    _container.RegisterType<TImplementer>(new ContainerControlledLifetimeManager());
                    break;
                case LifeStyle.Transient:
                    _container.RegisterType<TImplementer>(new TransientLifetimeManager());
                    break;
                default:
                    _container.RegisterType<TImplementer>(new TransientLifetimeManager());
                    break;
            }
        }
    }
}
