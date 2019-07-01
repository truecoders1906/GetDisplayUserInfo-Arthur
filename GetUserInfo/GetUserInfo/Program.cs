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
            return You;
        }

        static void Answers(UserInfo UI)
        {
            Console.WriteLine("Hello, " + UI.FirstName + " " + UI.LastName + "!");
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
