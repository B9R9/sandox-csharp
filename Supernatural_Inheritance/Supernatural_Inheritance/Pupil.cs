using System;
namespace Supernatural_Inheritance
{
	public class Pupil
	{
		public string Title
		{ get; private set; }

		public string Origin
		{ get; private set; }

		public Pupil(string title)
		{
			Title = title;
		}

		public Pupil(string title, string origin)
		{
			Title = title;
			Origin = origin;
		}

		public Storm CastWindStorm()
		{
			Storm temp;
            if (String.IsNullOrEmpty(Origin))
                temp = new Storm("wind", false, Title);
			else
				temp = new Storm("wind", false, Title, Origin);
            return temp;
		}
	}
}

