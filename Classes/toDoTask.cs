using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13._1.Classes
{
    internal class ToDoTask
    {
        string Title { get; set; }
        public bool isCompleted { get; set; }

        public ToDoTask(string title)
        {
            Title = title;
            isCompleted = false;
        }

        public override string ToString()
        {
            return $"{Title} - {(isCompleted ? "Виконано" : "Не виконано")}";
        }
    }
}
