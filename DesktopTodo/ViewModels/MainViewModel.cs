using DesktopTodo.Events;
using DesktopTodo.Services;
using DesktopTodo.Views;
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
        public TransitionerHandler TransitionerHandler { get; set; }
        private EventBus _eventBus;
        public MainViewModel(TransitionerHandler helper, EventBus eventBus)
        {
            TransitionerHandler = helper;
            _eventBus = eventBus;

            TransitionerHandler.AddSlideAndGo(new LoginPage());
        }
    }
}
