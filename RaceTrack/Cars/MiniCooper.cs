using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class MiniCooper : RaceCar
    {
        public MiniCooper()
        {
            Name = "Mini Cooper";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} Opens their Sun Roof");
        }
    }
}