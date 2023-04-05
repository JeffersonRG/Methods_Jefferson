using System;

namespace Methods_Jefferson
{
    class Program
    {
        /// <summary>
        /// asks the user for two numbers and their name.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());
            
            //prints the multiplied number from the numbers that the user gave
            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            goodbye();
        }
        /// <summary>
        /// multiply the user's numbers that they gave together
        /// </summary>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// prints a welcome message with the user name to the console
        /// </summary>
        /// <param name="username">gets user's name</param>
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }
        /// <summary>
        /// Prints a goodbye message to the console.
        /// </summary>
        static void goodbye()
        {
            Console.WriteLine("Have a fantastic day");
        }
    }
}
