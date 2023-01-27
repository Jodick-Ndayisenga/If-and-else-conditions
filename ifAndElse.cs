using System;

namespace Conditions
{
    class myConditions
    {
        static void Main(string[] args)
        {

            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("How old are you?: ");
            string age = Console.ReadLine();
            int newAge = Convert.ToInt32(age);

            if (newAge <= 18)
            {
                Console.WriteLine($"I am sorry {firstName}, you are not allowed to vote!!");
            }
            else
            {
                Console.Write($"Whao!!, {firstName}, you can now vote for presidential elections!");
            }

            //string decision = (newAge <= 18)? $"I am sorry {firstName}, you are not allowed to vote!!": $"Whao!!, {firstName}, you can now vote for presidential elections!"

            // the above line can also work the same as the if and else above. It normally is referred to as short hand of if--else statements
        }
    }
}