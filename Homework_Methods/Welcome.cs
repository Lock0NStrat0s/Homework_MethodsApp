using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Methods;

public static class Welcome
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome!");
    }

    public static string GetFirstName()
    {
        Console.Write("What is your first name: ");
        return Console.ReadLine();
    }

    public static void GreetUser(string firstName)
    {
        Console.WriteLine($"Hello {firstName}.");
    }
}
