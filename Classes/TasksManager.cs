using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13._1.Classes
{
    class TasksManager
    {
        private ToDoTask[] tasks = new ToDoTask[5];
        private int tasksCount;

        public void PrintMenu()
        {
            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1. Додати нове завдання");
            Console.WriteLine("2. Показати всі завдання");
            Console.WriteLine("3. Позначити завдання як виконане");
            Console.WriteLine("4. Видалити завдання");
            Console.WriteLine("5. Вийти");
        }

        public void UserChoice(ref bool running)
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    SetTasks();
                    break;
                case "4":
                    DeleteTask();
                    break;        
                    case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Будь ласка, оберіть число від 1 до 5");
                    break;
            }
        }

        public void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Введіть назву завдання:");
            string taskName = Console.ReadLine();

            if (tasksCount == tasks.Length)
            {
                ArrayResize();
            }

            tasks[tasksCount] = new ToDoTask(taskName);
            tasksCount++;
        }

        public void ArrayResize()
        {
            int newSize = tasks.Length + 1;
            ToDoTask[] newArray = new ToDoTask[newSize];

            for (int i = 0; i < tasksCount; i++)
            {
                newArray[i] = tasks[i];
            }

            tasks = newArray;
        }

        public void ShowTasks()
        {
            Console.Clear();
            if (tasksCount == 0)
            {
                Console.WriteLine("Завдань ще немає.");
                return;
            }

            for (int i = 0; i < tasksCount; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        public void SetTasks()
        {
            
            ShowTasks();
            Console.Write("Введіть номер завдання, щоб позначити його як виконане: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasksCount)
            {
                tasks[index - 1].isCompleted = true;
            }
            else
            {
                Console.WriteLine("Невірне введення.");
            }
        }

        public void DeleteTask()
        {
            ShowTasks();
            Console.Write("Введіть номер завдання, щоб видалити його: ");
            if (int.TryParse(Console.ReadLine(), out int index ) && index >= 1 && index <= tasksCount)
            {
                for (int i = index - 1; i < tasksCount - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                tasksCount--;
            }
            else
            {
                Console.WriteLine("Невірне введення.");
            }
        }

        public void RunProgram()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                PrintMenu();
                UserChoice(ref running);
                if (running)
                {
                    Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                    Console.ReadKey();
                }
            }         
        }
    }
}
    




