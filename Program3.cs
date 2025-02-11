using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program3
    {

        static Dictionary<int, string> students = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose among the following options...");
                Console.WriteLine("1.Add new student record");
                Console.WriteLine("2.Remove the student by their ID");
                Console.WriteLine("3.Display all the student records");
                Console.WriteLine("4.Exit");
                Console.WriteLine("--------------------------------------");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AddStudent();
                }
                else if (option == 2)
                {
                    RemoveStudentById();
                }
                else if (option == 3)
                {
                    DisplayRecords();
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option.Please try again..");
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter student ID");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine("Id already exists.Please enter different Id");
                return;
            }

            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            students[id] = name;

            Console.WriteLine($"Student with ID:{id} and Name:{name} added");
            Console.WriteLine("----------------------------------------");

        }

        static void RemoveStudentById()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter the student Id");
            int id = int.Parse(Console.ReadLine());

            if (students.Remove(id))
            {
                Console.WriteLine($"Student with ID:{id} is removed.");
            }
            else
            {
                Console.WriteLine($"Student with ID:{id} not found");
            }
            Console.WriteLine("-----------------------------------");
        }


        static void DisplayRecords()

        {
            Console.WriteLine("\nID\t\tNAME");
            Console.WriteLine("---------------------------------");
            if (students.Count == 0)
            {
                Console.WriteLine("No student records to display");
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}\t\t{student.Value}");

            }
            Console.WriteLine("--------------------------------------");

        }
    }
}

