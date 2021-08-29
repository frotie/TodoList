using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DesktopTodo
{
    public interface ISingleton {}
    public interface ITransient {}
    public static class IoC
    {
        private static IServiceProvider _provider;
        public static T Resolve<T>() => _provider.GetRequiredService<T>();
        public static void Init()
        {
            var services = new ServiceCollection();

            services.Scan(s => 
                s.FromAssemblyOf<ITransient>()
                    .AddClasses(x => x.AssignableTo<ITransient>()).AsSelf().WithTransientLifetime()
                    .AddClasses(x => x.AssignableTo<ISingleton>()).AsSelf().WithSingletonLifetime()
                );

            _provider = services.BuildServiceProvider();
            foreach (var service in services.Where(s => s.Lifetime == ServiceLifetime.Singleton))
            {
                _provider.GetRequiredService(service.ServiceType);
            }
        }
    }
}