using System;
using System.Threading;

namespace strings
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a message: ");
            string message = Console.ReadLine();
            if (!string.IsNullOrEmpty(message))
            {
                System.Console.WriteLine(message.Length);
                for(int i=0; i<message.Length; i++)
                {
                    System.Console.Write($"{message[i]} ");
                    Thread.Sleep(200);
                }
                System.Console.WriteLine();
                for(int i=message.Length-1; i>=0; i--)
                {
                    System.Console.Write(message[i]);
                    Console.Write(" ");
                    // Thread.Sleep(200);
                }
                Console.WriteLine();

            } else 
            {
                Console.WriteLine("message is empty!");
            }
            PasswordChecker();
        }
        public static void PasswordChecker()
        {
            string password = null,passwordVerify = null;
            do {
                Console.WriteLine("Password verification! Passwords can not be blank.");
                Console.WriteLine();
                Console.Write("Enter a password: ");
                password = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter password again to verify: ");
                passwordVerify = Console.ReadLine();
            } while (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordVerify));

            if (password.Equals(passwordVerify)) 
            {
                System.Console.WriteLine("passwords match!");
            } else
            {
                System.Console.WriteLine("passwords do not match!");
            }

            
        }
    }
}