using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Nick : Driver
    {
        public Nick(RaceCar car) : base(car)
        {
            Name = "Nick";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
        
    }
}