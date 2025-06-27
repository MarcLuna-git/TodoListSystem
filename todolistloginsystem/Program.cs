using System;
using ToDoListProcess.Business;
using ToDoListProcess.Common;
using ToDoListProcess.DL;

namespace ToDoListUI
{
    internal class Program
    {
        static string? currentUser = null;

        //Dito mamimili kalang po if anong storage gusto nyong gamitin,pero now ang gamit kopo is Database na
        // static readonly ITaskData taskData = new InMemoryTask();
        // static readonly ITaskData taskData = new JsonFileTask();
        // static readonly ITaskData taskData = new TextFileTask();

        static readonly ITaskData taskData = new DbTaskData();
        static readonly DbUserManager userManager = new DbUserManager();
        static readonly ToDoListManager toDoManager = new(taskData);

        static void Main(string[] _)
        {
            Console.WriteLine("=== TO-DO LIST SYSTEM ===\n");

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Choose option: ");
            string? input = Console.ReadLine();

            if (input == "1")
            {
                if (Login())
                    MainMenu();
                else
                    Console.WriteLine("Login failed. Exiting...");
            }
            else if (input == "2")
            {
                Register();
                if (!string.IsNullOrEmpty(currentUser))
                    MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static bool Login()
        {
            while (true)
            {
                Console.Write("Username: ");
                string? user = Console.ReadLine();

                Console.Write("Password: ");
                string? pass = Console.ReadLine();

                if (userManager.Authenticate(user, pass))
                {
                    Console.WriteLine("Login successful!");
                    currentUser = user;
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password. Please try again.\n");
                }
            }
        }


        static void Register()
        {
            while (true)
            {
                Console.Write("Create username: ");
                string? user = Console.ReadLine();

                Console.Write("Create password: ");
                string? pass = Console.ReadLine();

                if (userManager.Register(user, pass))
                {
                    Console.WriteLine("Register Successfully!");
                    currentUser = user;
                    break;
                }
                else
                {
                    Console.WriteLine("Username already taken. Please try again.\n");
                }
            }
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Edit Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Mark as Done");
                Console.WriteLine("6. Search Task");
                Console.WriteLine("7. Logout");
                Console.Write("Option: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        EditTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        MarkDone();
                        break;
                    case "6":
                        SearchTask();
                        break;
                    case "7":
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void ViewTasks()
        {
            var tasks = toDoManager.GetAllTasks(currentUser);
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("\n--- Your Tasks ---");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Task}  |  Added: {tasks[i].DateAndTime:yyyy-MM-dd HH:mm:ss}");
            }
        }

        static void AddTask()
        {
            Console.Write("Task description: ");
            string? desc = Console.ReadLine();

            bool success = toDoManager.AddTask(currentUser, desc);
            Console.WriteLine(success ? "Task added." : "Please enter a valid task description.");
        }

        static void EditTask()
        {
            ViewTasks();
            Console.Write("Task number to edit: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                Console.Write("New description: ");
                string? newDesc = Console.ReadLine();
                bool success = toDoManager.EditTask(index - 1, newDesc, currentUser);
                Console.WriteLine(success ? "Task updated." : "Failed: invalid index or empty description.");
            }
            else Console.WriteLine("Invalid number.");
        }

        static void DeleteTask()
        {
            ViewTasks();
            Console.Write("Task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                bool success = toDoManager.DeleteTask(index - 1, currentUser);
                Console.WriteLine(success ? "Task deleted." : "Invalid task number.");
            }
            else Console.WriteLine("Invalid number.");
        }

        static void MarkDone()
        {
            ViewTasks();
            Console.Write("Task number to mark as done: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                bool success = toDoManager.MarkAsDone(index - 1, currentUser);
                Console.WriteLine(success ? "Task marked as done." : "Invalid task number.");
            }
            else Console.WriteLine("Invalid number.");
        }

        static void SearchTask()
        {
            Console.Write("Keyword to search: ");
            string? key = Console.ReadLine();

            var results = toDoManager.SearchTasks(key, currentUser);
            if (results.Count == 0)
            {
                Console.WriteLine("No matches found.");
                return;
            }

            Console.WriteLine("Search Results:");
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {results[i].Task}  |  Added: {results[i].DateAndTime:yyyy-MM-dd HH:mm:ss}");
            }
        }
    }
}