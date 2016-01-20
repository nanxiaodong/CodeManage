using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.Common
{
    public interface IObjectContainer
    {
        void RegisterType(Type implementationType, LifeStyle life = LifeStyle.Singleton);
        void RegisterType(Type serviceType, Type implementationType, LifeStyle life = LifeStyle.Singleton);

        void Register<TImplementer>(LifeStyle life = LifeStyle.Singleton)
         where TImplementer : class;

        void Register<TService, TImplementer>(string name, LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService;

        void Register<TService, TImplementer>(LifeStyle life = LifeStyle.Singleton)
            where TService : class
            where TImplementer : class, TService;


        void RegisterInstance<TService, TImplementer>(TImplementer instance)
            where TService : class
            where TImplementer : class, TService;

        TService Resolve<TService>() where TService : class;

        TService Resolve<TService>(string name) where TService : class;

        object Resolve(Type serviceType);

        object Resolve(string name, Type serviceType);

        TService Resolve<TService>(Type type, object param) where TService : class;

        TService Resolve<TService>(string name, object param) where TService : class;

        void RegisterType(Type serviceType, Type implementationType, string name, LifeStyle life = LifeStyle.Singleton);
    }
}
