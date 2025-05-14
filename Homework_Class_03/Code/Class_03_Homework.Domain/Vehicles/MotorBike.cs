//Create class MotorBike that will inherit from Vehicle and
//will implement the respective method;
using Class_03_Homework.Domain.Models;

namespace Class_03_Homework.Domain.Vehicles
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
        public MotorBike() { }
    }
}
