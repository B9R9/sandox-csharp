using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string password;
        private string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 8)
                {
                    Console.WriteLine("You need a 8 characters password minimun!");
                    password = "";
                }
                else
                {
                    password = value;
                }
            }
        }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol
        { get; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            HeaderSymbol = "-";
        }

        public void Display()
        {
            int index = 0;
            Console.WriteLine("Password");
            for (int i = 0; i < 5; i++)
                Console.Write(HeaderSymbol);
            Console.WriteLine("");
            if (Hidden)
            {
                while (index < Password.Length - 1)
                {
                    Console.Write("*");
                    index++;
                }

            }
            else
            {
                if (String.IsNullOrEmpty(Password))
                {
                    Console.WriteLine("Please set a min 8 character Password!");
                }
                else
                {
                    Console.WriteLine(Password);
                }
            }

        }

        public void Reset()
        {
            Hidden = false;
            Password = "";
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (newPassword.Length >= 8 && (oldPassword == Password || String.IsNullOrEmpty(Password)))
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}