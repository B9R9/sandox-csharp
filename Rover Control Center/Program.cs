using System;

namespace RoverControlCenter
{
	class Program
	{
		static void Main(string[] args)
		{
			MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
    		MoonRover apollo = new MoonRover("Apollo 15", 1971);
      		MarsRover sojourner = new MarsRover("Sojourner", 1997);
      		Satellite sputnik = new Satellite("Sputnik", 1957); 

			Rover[] rovers = { lunokhod, apollo, sojourner};
			DirectAll(rovers);

			IDirectable[] probes = {lunokhod, apollo, sojourner, sputnik};

			foreach (IDirectable probe in probes)
			{
				Console.WriteLine(probe.GetType());
			}
		}
		static void DirectAll(IDirectable[] rovers)
		{
			foreach (IDirectable rover in rovers)
			{
				Console.WriteLine(rover.GetInfo());
				Console.WriteLine(rover.Explore());
				Console.WriteLine(rover.Collect());
			}
		}
	}
	
}