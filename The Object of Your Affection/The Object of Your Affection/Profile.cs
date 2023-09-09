using System;
using System.Collections.Generic;

namespace The_Object_of_Your_Affection
{
	public class Profile
	{
		//FIELDS
		public string name;
		private int age;
		public string city;
		public string country;
		public string pronouns;
		public string[] hobbies;


		//Constructor

		static Profile()
		{
			ProfileCreated = 0;
		}
		public Profile(string name, int age, string city = "Unknown", string country = "Unknown", string pronouns = "They/Them")
		{
			this.Name = name;
			this.Age = age;
			this.City = city;
			this.Country = country;
			this.Pronouns = pronouns;


			this.name = name;
			this.age = age;
			this.city = city;
			this.country = country;
			this.pronouns = pronouns;
			ProfileCreated++;
		}


		//Properties

		public string Name
		{ get; set; }

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
		{ get; set; }

		public string Country
		{ get; set; }

		public string Pronouns
		{ get; set; }

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
				You need to be over 18 years old to subcripeto use service.
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