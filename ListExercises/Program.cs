using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(EvenSum(numList));


            List<string> stringList = new List<string> { "first", "second", "third", "fourth", "fifth", "sixth", "seventh" };

            Console.WriteLine("Enter word length: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(LetterCheck(input, stringList));


        }

        static int EvenSum(List<int> list)
        {
            int sum = 0;
            foreach(int number in list)
            {
                if(number%2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        static string LetterCheck(int number, List<String> list)
        {
            int numWord = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length == number)
                {
                    Console.WriteLine(list[i]);
                    numWord++;
                }
            }
            
            if(numWord == 0)
            {
                return "No match found.";
            }
            else
            {
                return $"Your query returned {numWord} words.";
            }
        }
    }
}
