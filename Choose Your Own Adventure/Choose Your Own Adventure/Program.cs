using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello, {name}! Welcome to our story.\n");

            Console.WriteLine("""
                It begins on a cold and heavy rainy night.
                You're  sitting in your room and hear a noise coming from down
                the hall.
                """);
            Console.Write("Do you go investigate? Yes or No?: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            if (noiseChoice == "NO")
            {
                Console.WriteLine($"""
                    Not Much of an adventureif we don't leave our room!
                    THE END.
                    """);
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine($"""
                    You walk into the hallway and see a light coming from under
                    a door down the hall. You walk towards it.
                    """);
                Console.Write("Do you open it or knock? Open or Knock: ");
                string doorChoice = Console.ReadLine().ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine($"""
                        A voice behind the door speaks. It says:
                        "Answer this riddle:
                        Poor People have it. Rich people need it. If you eat
                        it you die. What is it ?"
                        """);
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("""
                            The door opens and NOTHING is there. You turn off
                            the light and run back to your room and lock the
                            door.
                            THE END.
                            """);
                    }
                    else
                    {
                        Console.WriteLine("""
                            You answered incorrectly. The door doesn't open.
                            THE END.
                            """);
                    }

                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("""
                        The door is locked! See if one of your three keys will
                        open it.
                        """);
                    Console.Write("Enter a number (1-3): ");
                    string numberChoice = Console.ReadLine();

                    switch (numberChoice)
                    {
                        case "1":
                            Console.WriteLine($"""
                                You choose the key number {numberChoice}.
                                Lucky choice!
                                The door opens  and NOTHING is there.
                                Strange ...
                                THE END.
                                """);
                            break;
                        case "2":
                        case "3":
                            Console.WriteLine($"""
                                You choose the key number {numberChoice}.
                                The door doesn't open.
                                THE END.
                                """);
                            break;
                        default:
                            break;
                    }

                }
            }

            Console.WriteLine("Press enter to quit ...");
            Console.ReadLine();
        }
    }
}