using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Andrew_Conley_Mini_Projects_Assignment;

class Program
{
    internal class User
    {
        internal string Username { get; set; }
        internal User(string username)
        {
            Username = username;
        }
    }
    static void Main(string[] args)
    {
        string localUserDatabase = "local_users.txt";
        string onlineDirectory = "online_users.txt";

        List<string> localUsers = File.ReadAllLines(localUserDatabase).ToList();
        List<string> onlineUsers = File.ReadAllLines(onlineDirectory).ToList();

        var localOrphans = localUsers.Except(onlineUsers).ToList();
        var onlineOrphans = onlineUsers.Except(localUsers).ToList();

        Console.WriteLine("Local Orphans:");
        foreach (var User in localOrphans)
        {
            Console.WriteLine(User);
        }
        Console.WriteLine("Online Orphans:");
        foreach (var User in onlineOrphans)
        {
            Console.WriteLine(User);
        }
    }
}
