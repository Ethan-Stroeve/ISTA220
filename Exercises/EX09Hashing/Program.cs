using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EX09Hashing
{
    class Program : AuthenticateSystem
    {
        static void Main(string[] args)
        {
            StartSytem();
        }
    }
}

public class AuthenticateSystem
{
    public static Dictionary<string, byte[]> userCredentials = new Dictionary<string, byte[]>();
    public static string userName { get; set; }
    public static string password { get; set; }
    public static byte[] hashedBytes { get; set; }

    public static void StartSytem()
    {
        printUI();
        int userResponse = int.Parse(Console.ReadLine());
        while (userResponse != 0)
        {
            if (userResponse == 1)
            {
                getNewUser();
                StartSytem();
            }
            else if (userResponse == 2)
            {
                getUser();
                StartSytem();
            }
            else if (userResponse == 3)
            {
                PrintUsers();
                StartSytem();
            }
            else
            {
                Console.WriteLine("Sorry that input does not work");
            }
        }
        Console.WriteLine("Goodbye");
        Environment.Exit(0);
    }

    public static void printUI()
    {
        Console.Clear();
        Console.WriteLine("Password Authentication System\x0A" +
            "Please select an option or enter 0 to exit\x0A" +
            "1. Establish an account\x0A" +
            "2. Authenticate a user\x0A" +
            "3. Exit the system");
    }

    public static void printUI2()
    {
        Console.WriteLine("Please Enter a Username, press enter when done");
        userName = Console.ReadLine();
        Console.WriteLine("Please Enter a Password, press enter when done");
        password = Console.ReadLine();
    }

    public static void getNewUser()
    {
        printUI2();
        if (!userCredentials.ContainsKey(userName))
        {
            HashPassword();
            userCredentials.Add(userName, hashedBytes);
        }
        else
        {
            Console.WriteLine("Username already exist");
            getNewUser();
        }
    }

    public static void getUser()
    {
        printUI2();
        if (userCredentials.ContainsKey(userName))
        {
            byte[] checkPassword = userCredentials[userName];
            if (checkPassword == hashedBytes)
            {
                Console.WriteLine("User Authenticated");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Username or password is incorrect");
                Console.ReadKey();
                getUser();
            }

        }
        else
        {
            Console.WriteLine("Username or password is incorrect");
            Console.ReadKey();
            getUser();
        }
    }

    public static string HashPassword()
    {
        using var sha256 = SHA256.Create();
        // Send a sample text to hash.  
        hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        // Get the hashed string.  
        return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

    }

    public static void PrintUsers()
    {
        Console.WriteLine("USERNAME : PASSWORD : HASHCODE");
        foreach (var item in userCredentials)
        {
            Console.WriteLine($"{userName}: {password}: {HashPassword()}");
        }
        Console.ReadKey();
    }



}
