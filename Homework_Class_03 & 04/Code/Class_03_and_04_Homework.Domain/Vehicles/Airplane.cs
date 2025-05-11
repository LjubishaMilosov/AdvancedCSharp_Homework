using Class_03_and_04_Homework.Domain.Models;
namespace Class_03_and_04_Homework.Domain.Vehicles

{
    public class Airplane : Vehicle
    {
        public Airplane() { }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
