using Class_04_Homework.Domain.Models;
namespace Class_04_Homework.Domain.Vehicles

{
    public class Car : Vehicle
    {
        public Car() { }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
