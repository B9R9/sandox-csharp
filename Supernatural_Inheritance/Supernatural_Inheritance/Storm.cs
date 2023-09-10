using System;
namespace Supernatural_Inheritance
{
	public class Storm
	{
		public string Essence
		{ get; private set; }

		public bool IsStrong
		{ get; private set; }

		public string Caster
		{ get; private set; }

		public string Origin
		{ get; private set; }

        public Storm(string essence, bool isstrong, string caster)
        {
            Essence = essence;
            IsStrong = isstrong;
            Caster = caster;
        }

        public Storm(string essence, bool isstrong, string caster, string origin)
		{
			Essence = essence;
			IsStrong = isstrong;
			Caster = caster;
			Origin = origin;
		}

        public string Announce()
		{
			string strong = (IsStrong) ? "strong" : "weak";
			string origin = String.IsNullOrEmpty(Origin)? "" : " from " + Origin;
			string temp = Caster + origin + " cast a " + strong + " " + Essence + " storm!";
			return temp;
		}
	}
}