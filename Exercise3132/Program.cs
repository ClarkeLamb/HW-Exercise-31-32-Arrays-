using System;

namespace Exercise3132
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            //#31
            int[] arrayNumbers = new int[] { 2, 8, 0, 24, 51 };
            do
            {
                Console.WriteLine("Please pick an index.");
                int userIndex = int.Parse(Console.ReadLine());
                int place = arrayNumbers[userIndex];

                Console.WriteLine("The value at index " + userIndex + " is " + place);
                Console.WriteLine("Would youlike to continue? y/n");
                answer = Console.ReadLine();

            } while (answer != "n");

            Console.WriteLine("Goodbye");


            //#32
            int[] cincoNumbers = new int[] { 2, 8, 0, 24, 51 };
            int foundIndex = -1;
            do
            {
                Console.WriteLine("Please enter a number.");
                int userInput = int.Parse(Console.ReadLine());



                for (int i = 0; i < cincoNumbers.Length; i++)
                {
                    if (cincoNumbers[i] == userInput)
                    {
                        foundIndex = cincoNumbers[i];
                        Console.WriteLine("The value of " + userInput + " can be found at index " + foundIndex);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vlaue cannot be found in array.");
                    }
                }

                Console.WriteLine("Would youlike to continue? y/n");
                answer = Console.ReadLine();

            } while (answer.ToLower() != "n");
            Console.WriteLine("Goodbye");
        }
    }
}
