using System;
namespace Supernatural_Inheritance
{
	public class Mage : Pupil
	{

		public Mage(string title) :base(title)
		{
		}

        public Mage(string title, string origin) : base(title, origin)
        {
        }

        public virtual Storm CastRainStorm()
		{
			Storm temp;
			if (String.IsNullOrEmpty(Origin))
				temp = new Storm("rain", false, Title);
			else
                temp = new Storm("rain", false, Title, Origin);
            return temp;
		}
	}
}

