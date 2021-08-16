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
            _eventBus.Subscribe<HelloEvent>(async e =>
            {
                MessageBox.Show("Hi from EventBus!");
            });
        }

        public ICommand ClickMe => new RelayCommand(async o =>
        {
            await _eventBus.Publish(new HelloEvent());
        });
    }
}
