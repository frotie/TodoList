using DesktopTodo.Models; 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo.ViewModels
{
    class TodoListViewModel : ViewModelBase
    {
        public ObservableCollection<TodoTask> TodoTasks { get; set; }
        public TodoListViewModel()
        {
            TodoTasks = new ObservableCollection<TodoTask>();
            TodoTasks.Add(new TodoTask()
            {
                Id = 1,
                Name = "Проверочное задание №1",
                Description = "Написать программу, залить на гитхаб, добавить в портфолио, устроиться на работу",
                IsCompleted = false,
                Priority = 1,
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(1),
            });
        }
    }
}
