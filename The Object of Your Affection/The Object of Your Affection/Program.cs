using System;

namespace The_Object_of_Your_Affection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 23);
            Console.WriteLine(sam.ViewProfile());
            string[] hobbies = { "Blo", "Bla", "Bli" };
            string[] hobbies2= { "Clo", "cla", "cli" };
            sam.SetHobbies(hobbies);
            Console.WriteLine(sam.ViewProfile());
            sam.SetHobbies("Lecture");
            Console.WriteLine(sam.ViewProfile());
            sam.SetHobbies(hobbies2);
            Console.WriteLine(sam.ViewProfile());
            Console.WriteLine(Profile.ProfileCreated);


            Profile bob = new Profile("Bob Bylan", 17);
        }
    }
}
