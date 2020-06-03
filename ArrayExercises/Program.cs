using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 1, 2, 3, 5, 8 };

            for (int i=0; i<intArray.Length; i++)
            {
                if(intArray[i]%2 != 0)
                {
                    Console.WriteLine(intArray[i]);
                }
            }
        }
    }
}
