using Class_04_Homework.Domain.Vehicles;

namespace Class_04_Homework.Domain.Extensions
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("Driving");
        }
        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("Driving on one wheel");
        }
        public static void Sail(this Boat boat)
        {
            Console.WriteLine("Sailing");
        }
        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("Flying");
        }
    }
}
