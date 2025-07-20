using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13._1.Classes
{
    internal class toDoTask
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public toDoTask(string title)
        {
            Title = title;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Title} - {(IsCompleted ? "Виконано" : "Не виконано")}";
        }
    }
}


