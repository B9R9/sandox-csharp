using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digit = "0123456789";
            string specialchar = "~:+[\\@^{%(-\"*|,&<\'}._=]!>;?#$)/";
            int score = 0;

            Console.WriteLine("Enter your Password:");
            string userPassword = Console.ReadLine();

            if (userPassword.Length >= minLength)
                score += 1;
            if (Tools.Contains(userPassword, uppercase))
                score += 1;
            if (Tools.Contains(userPassword, lowercase))
                score += 1;
            if (Tools.Contains(userPassword, digit))
                score += 1;
            if (Tools.Contains(userPassword, specialchar))
                score += 1;

            switch (score)
            {
                case 1:
                    Console.WriteLine("The password is weak.");
                    break;
                case 2:
                    Console.WriteLine("The password is medium.");
                    break;
                case 3:
                    Console.WriteLine("The password is strong.");
                    break;
                case 4:
                case 5:
                     Console.WriteLine("The password is extremely strong.");
                     break;
                default:
                     Console.WriteLine("The password doesn’t meet any of the standards.");
                     break;
            }
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();

        }
    }
}