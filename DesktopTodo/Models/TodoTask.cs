using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopTodo.Models
{
    class TodoTask
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
    }
}
