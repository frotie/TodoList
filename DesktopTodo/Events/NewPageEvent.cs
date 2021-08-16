using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopTodo.Events
{
    class NewPageEvent : IEvent
    {
        public UserControl Page { get; set; }
        public NewPageEvent(UserControl page = null)
        {
            Page = page;
        }
    }
}
