using Class_03_and_04_Homework.Domain.Models;
namespace Class_03_and_04_Homework.Domain.Vehicles
{
    public class MotorBike : Vehicle
    {
        public MotorBike() { }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
    }
}
