using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
        class Program
        {
            // List to store the tasks
            static List<string> todoList = new List<string>();

            static void Main(string[] args)
            {
                int choice;

                do
                {
                    Console.WriteLine("\n===== TO-DO LIST =====");
                    Console.WriteLine("1. Add a task");
                    Console.WriteLine("2. View all tasks");
                    Console.WriteLine("3. Mark a task as complete");
                    Console.WriteLine("4. Remove a task");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice (1-5): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddTask();
                            break;
                        case 2:
                            ViewTasks();
                            break;
                        case 3:
                            CompleteTask();
                            break;
                        case 4:
                            RemoveTask();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the application...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please select again.");
                            break;
                    }
                } while (choice != 5);
            }

            // Add a new task to the list
            static void AddTask()
            {
                Console.Write("Enter a new task: ");
                string task = Console.ReadLine();
                todoList.Add(task);
                Console.WriteLine("Task added successfully.");
            }

            // View all tasks in the list
            static void ViewTasks()
            {
                if (todoList.Count == 0)
                {
                    Console.WriteLine("No tasks in the list.");
                }
                else
                {
                    Console.WriteLine("\n--- To-Do List ---");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todoList[i]}");
                    }
                }
            }

            // Mark a task as complete
            static void CompleteTask()
            {
                ViewTasks();
                if (todoList.Count > 0)
                {
                    Console.Write("Enter the task number to mark as complete: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());

                    if (taskNumber > 0 && taskNumber <= todoList.Count)
                    {
                        todoList[taskNumber - 1] += " (Completed)";
                        Console.WriteLine("Task marked as complete.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
            }

            // Remove a task from the list
            static void RemoveTask()
            {
                ViewTasks();
                if (todoList.Count > 0)
                {
                    Console.Write("Enter the task number to remove: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());

                    if (taskNumber > 0 && taskNumber <= todoList.Count)
                    {
                        todoList.RemoveAt(taskNumber - 1);
                        Console.WriteLine("Task removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
            }
        }
}
