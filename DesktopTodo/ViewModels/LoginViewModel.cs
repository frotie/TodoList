using DesktopTodo.Events;
using DesktopTodo.Services;
using DesktopTodo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopTodo.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        public string ErrorText { get; set; }
        public string Login { get; set; }
        private bool _isBusy;
        private EventBus _eventBus;
        public LoginViewModel(EventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public ICommand AuthCommand => new RelayCommand(async pwd =>
        {
            _isBusy = true;

            string password = (pwd as System.Windows.Controls.PasswordBox).Password;
            await Task.Delay(3000);
            // ErrorText = "Неверный логин или пароль";
            await _eventBus.Publish(new NewPageEvent(new TodoListPage()));

            _isBusy = false;
        }, (pwd) => !_isBusy);
    }
}
