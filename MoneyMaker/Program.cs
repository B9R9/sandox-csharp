// See https://aka.ms/new-console-template for more information
using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double  userAmount;
            int     goldValue;
            int     silverValue;
            int goldCoin;
            int silverCoin;
            int remainder;

            goldValue = 10;
            silverValue = 5;
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins?");
            userAmount = Math.Floor(Convert.ToDouble(Console.ReadLine()));

            goldCoin = (int)Math.Floor(userAmount / goldValue);
            remainder = (int)userAmount % goldValue;
            silverCoin = (int)Math.Floor((double)remainder / silverValue);
            remainder = (int)remainder % silverValue;
            Console.WriteLine($"{userAmount} in coins is equal to {goldCoin}" +
            $" gold coins, {silverCoin} silver coins and {remainder} bronze coins!");
            Console.WriteLine("Press Enter to quit ...");
            Console.ReadLine();

        }
    }
}
