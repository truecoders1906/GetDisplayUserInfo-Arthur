using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo UI = Questions();
            Answers(UI);
        }

        static UserInfo Questions()
        {
            UserInfo You = new UserInfo();
            Console.WriteLine("What is your first name?");
            You.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            You.LastName = Console.ReadLine();
            You.FavoriteNumber = GetIntFromUser("What is your favorite number?");
            return You;
        }

        static int GetIntFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        static void Answers(UserInfo UI)
        {
            Console.WriteLine("Hello, " + UI.FirstName + " " + UI.LastName + "!");
            Console.WriteLine("Your favorite number is " + UI.FavoriteNumber + "!");
        }
    }
    class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FavoriteNumber { get; set; }
        public int NumberOfPets { get; set; }
        public string NamesOfAllPets { get; set; }
    }
}
