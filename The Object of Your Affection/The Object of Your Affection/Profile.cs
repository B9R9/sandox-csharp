using System;
using System.Collections.Generic;

namespace The_Object_of_Your_Affection
{
	public class Profile
	{
		//FIELDS
		private string name;
		private int age;
		private string city;
		private string country;
		private string pronouns;
		private string[] hobbies;


		//Constructor

		static Profile()
		{
			ProfileCreated = 0;
		}
		public Profile(string name, int age, string city = "Unknown", string country = "Unknown", string pronouns = "They/Them")
		{
			Name = name;
			Age = age;
			City = city;
			Country = country;
			Pronouns = pronouns;
			ProfileCreated++;
		}


		//Properties

		public string Name
		{ get { return name; }
		  set
			{ if (value == null)
				{ Console.WriteLine("We need this field!"); }
			else
				{ name = value; }
			}
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 18)
				{ UnderAge(); }
				else
				{ age = value; }
			}
		}
		public string City
		{
			get { return city; }
			set { city = value; }
		}

		public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Pronouns
        {
            get { return pronouns; }
            set { pronouns = value; }
        }

        public string[] Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }

        public static int ProfileCreated
		{ get; set; }

		//Method

		public string ViewProfile()
		{
			string profile = $"""
				Name	:	{name}
				Age	:	{age}
				City	:	{city}
				Country	:	{country}
				Pronouns:	{pronouns}
				Hobbies	:	{HobbieList()}
				""";
			return profile;
		}

		public void SetHobbies(string[] hobbies)
		{
			if (this.hobbies == null)
			{
				this.hobbies = hobbies;
			}
			else
			{
				List<string> result;
				List<string> temp = this.hobbies.ToList();
				List<string> addtemp = hobbies.ToList();
				result = temp.Concat(addtemp).ToList();
				this.hobbies = result.ToArray();
			}
        }

        public void SetHobbies(string hobbie)
        {
			List<string> temp = this.hobbies.ToList();
			temp.Insert(0, hobbie);
            this.hobbies = temp.ToArray();
        }

        private void UnderAge()
		{
			Console.WriteLine("""
				You need to be over 18 years old to subcripe and use service.
				""");
		}

		private string HobbieList()
		{
			if (hobbies == null)
				return ("n/a");
			string hobbiesL;
			hobbiesL = String.Join(", ", hobbies);
			return hobbiesL;
		}
	}

}