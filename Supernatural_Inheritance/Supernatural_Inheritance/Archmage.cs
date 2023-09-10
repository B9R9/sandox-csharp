using System;
namespace Supernatural_Inheritance
{
	public class Archmage :Mage
	{
		public Archmage(string name): base(name)
		{
		}

        public Archmage(string name, string origin) : base(name, origin)
        {
        }

        public override Storm CastRainStorm()
		{
            Storm temp;
            if (String.IsNullOrEmpty(Origin))
                temp = new Storm("rain", true, Title);
			else
                temp = new Storm("rain", true, Title, Origin);
            return temp;
		}

		public Storm CastLightningStorm()
		{
            Storm temp;
            if (String.IsNullOrEmpty(Origin))
                temp = new Storm("Lightning", true, Title);
            else
                temp = new Storm("Lightning", true, Title, Origin);
            return temp;
		}

    }
}

