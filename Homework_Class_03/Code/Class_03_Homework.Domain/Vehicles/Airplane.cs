//Create class Airplane that will inherit from Vehicle and
//will implement the respective method;

using Class_03_Homework.Domain.Models;

namespace Class_03_Homework.Domain.Vehicles
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }
        public Airplane() { }
    }
}
