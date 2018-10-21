using System;
using System.Collections.Generic;

namespace _2UserClass
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
            }
        }

    }

    class User
    {
        private static List<string> userList = new List<string>();
        public void Add(string s)
        {
            userList.Add(s);
        }


      public  int GetUsersCount()
        {
            return userList.Count;
        }
    }
}
