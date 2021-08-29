using DesktopTodo.Services;
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
        public MainViewModel MainViewModel => IoC.Resolve<MainViewModel>();
        public LoginViewModel LoginViewModel => IoC.Resolve<LoginViewModel>();
        public TodoListViewModel TodoListViewModel => IoC.Resolve<TodoListViewModel>();
    }
}
