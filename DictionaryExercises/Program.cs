using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int idNum;
            string newStudent;

            Console.WriteLine("Enter student name (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student: ");
                newStudent = Console.ReadLine();

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID Number: ");
                    idNum = int.Parse(Console.ReadLine());
                    students.Add(idNum, newStudent);

                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"Student ID: {student.Key} \n Student Name: {student.Value}\n");
            }
        }
    }
}
