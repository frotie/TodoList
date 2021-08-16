using DesktopTodo.Events;
using DesktopTodo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DesktopTodo.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private EventBus _eventBus;
        public MainViewModel(EventBus eventBus)
        {
            _eventBus = eventBus;
        }
    }
}
