// See https://aka.ms/new-console-template for more information
using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
		*In this project, we’ll use C# to write a Mad Libs word game!
		Mad Libs are short stories with blanks for the player to fill
		in that represent different parts of speech. The end result is
		a really hilarious and strange story.
		*/
		// Let the user know that the program is starting:
		Console.WriteLine("The MadLibs start here!!\n");
		// Give the Mad Lib a title:
		Console.WriteLine("Choose your title?");
		string title = Console.ReadLine();
		Console.WriteLine(title);
		// Define user input and variables:
		Console.WriteLine("Enter a name?");
		string name = Console.ReadLine();
		string[] adj = new string[3];
		for (int i = 0; i < 3; i++){
			Console.WriteLine($"Enter adj number {i + 1}:");
			adj[i] = Console.ReadLine();
		}
		Console.WriteLine("Enter a verb:");
		string verb = Console.ReadLine();
		string[] nouns = new string[2];
		for (int i = 0; i < 2; i++){
			Console.WriteLine($"Enter noun{i + 1}:");
			nouns[i] = Console.ReadLine();
		}
		string[] divers = new string[] {"a animal", "a food", "a fruit", "a superhero", " a country", "a dessert", "a year"};
		string[] divers_answer = new string[divers.Length];
		for (int i = 0; i < divers.Length;i++){
			Console.WriteLine($"Enter {divers[i]}:");
			divers_answer[i] = Console.ReadLine();
		}
		// The template for the story:
		string story = $"This morning {name} woke up feeling {adj[0]}. 'It is going to be a {adj[1]} day!' Outside, a bunch of {divers_answer[0]}s were protesting to keep {divers_answer[1]} in stores. They began to {verb} to the rhythm of the {nouns[0]}, which made all the {divers_answer[2]}s very {adj[2]}. Concerned, {name} texted {divers_answer[3]}, who flew {name} to {divers_answer[4]} and dropped {name} in a puddle of frozen {divers_answer[5]}. {name} woke up in the year {divers_answer[6]}, in a world where {nouns[1]}s ruled the world.";


      // Print the story:
	  Console.WriteLine(story);

    }
  }
}
