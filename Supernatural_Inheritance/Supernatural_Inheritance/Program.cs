using System;

namespace Supernatural_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Storm test = new Storm("wind", false, "Zul'rajas");

            Console.WriteLine(test.Announce());

            Pupil p1 = new Pupil("Mezil - kree");

            Console.WriteLine(p1.CastWindStorm().Announce());

            Mage m1 = new Mage("Gul’dan");
            Console.WriteLine(m1.CastRainStorm().Announce());

            Archmage a1 = new Archmage("Nielas Aran");
            Console.WriteLine(a1.CastRainStorm().Announce());
            Console.WriteLine(a1.CastLightningStorm().Announce());

            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            Mage m = new Mage("Gul'dan", "Draenor");
            Archmage a = new Archmage("Nielas Aran", "Stormwind");

            Console.WriteLine(p.CastWindStorm().Announce());
            Console.WriteLine(m.CastRainStorm().Announce());
            Console.WriteLine(a.CastLightningStorm().Announce());



        }
    }
}