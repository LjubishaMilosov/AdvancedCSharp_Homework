//Create class Car that will inherit from Vehicle and
//will implement the respective method;
using Class_03_Homework.Domain.Models;

namespace Class_03_Homework.Domain.Vehicles
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }
        public Car() { }
    }
}
