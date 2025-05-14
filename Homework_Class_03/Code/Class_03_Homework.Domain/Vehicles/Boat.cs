//Create class Boat that will inherit from Vehicle and
//will implement the respective method;
using Class_03_Homework.Domain.Models;

namespace Class_03_Homework.Domain.Vehicles
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }
        public Boat() { }
    }
}
