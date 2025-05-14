using Class_04_Homework.Domain.Models;
namespace Class_04_Homework.Domain.Vehicles

{
    public class Boat : Vehicle
    {
        public Boat() { }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }

        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
    }

}
