﻿using DesktopTodo.Services;
using DesktopTodo.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo
{
    class ViewModelLocator
    {
        private static ServiceProvider _provider;
        public static void Init()
        {
            ServiceCollection services = new ServiceCollection();

            // Viewmodels
            services.AddTransient<MainViewModel>();

            // Services
            services.AddSingleton<EventBus>();
            services.AddSingleton<MessageBus>();
            services.AddSingleton<TransitionerHandler>();

            // Build provider and check dependencies
            _provider = services.BuildServiceProvider();
            foreach(var service in services)
            {
                _provider.GetRequiredService(service.ServiceType);
            }
        }

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
    }
}
