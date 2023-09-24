using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
/*
	  var eachLanguage = languages.Select(line => line.Prettify());
	  foreach(var n in eachLanguage)
	 	Console.WriteLine(n);
*/	
/*
	  var csharp = languages
	  	.Where (n => n.Name.Contains("C#"))
		.Select (n => n.Prettify());
	  foreach (var n in csharp)
	  	Console.WriteLine(n);
*/
/*
	  var microsoft = from n in languages
	  	where (n.ChiefDeveloper.Contains("Microsoft"))
		select (n.Prettify());
	  foreach (var n in microsoft)
	  	Console.WriteLine(n);	
*/
/*	 
	  var predecessorsLisp = from n in languages
	  	where (n.Predecessors.Contains("Lisp"))
		select (n.Prettify());
	  foreach (var n in predecessorsLisp)
	  	Console.WriteLine(n);
*/
/*
	  var scriptLanguage = from n in languages
	  	where (n.Name.Contains("Script"))
		select(n.Name);
	  foreach (var n in scriptLanguage)
	  	Console.WriteLine(n);
*/
/*
	  Console.WriteLine(languages.Count());
	
	  var between = languages
		.Where (n => n.Year >= 1995 && n.Year <= 2005)
		.Select (n => n.Prettify());
	  Console.WriteLine(between.Count());
*/
/*
	  var millenium = from n in languages
	  	where (n.Year >= 2000)
		select ($"{n.Name} was invented in {n.Year}");
	  foreach (var n in millenium)
	  	Console.WriteLine(n);
	  var millenium2 = from n in languages
	  	where (n.Year >= 2000)
		select (n);
	  Language.PrettyPrintAll(millenium2);
	  Language.PrintAll(millenium);
*/
	  var orderedLang = languages
		.OrderBy(n => n.Name)
		.Select(n => $"{n.Name} {n.Year}");
	  Language.PrintAll(orderedLang);

	  var oldest = languages.Select(n => n.Year).Min();
	  Console.WriteLine(oldest);

	  var olderLang = languages
	  	.Where(n => n.Year == oldest)
		.Select(n => $"{n.Name} is the oldest language. It was created in {n.Year}");
	  Language.PrintAll(olderLang);
	}
  }
}
