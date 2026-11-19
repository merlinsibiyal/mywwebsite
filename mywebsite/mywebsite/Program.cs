using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Student Registration");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Registration Successful!");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
    }
}