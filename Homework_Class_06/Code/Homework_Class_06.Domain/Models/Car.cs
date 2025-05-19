
namespace Homework_Class_06.Domain.Models
{
    public class Car
    {
        public string Model { get; set; }
        public double MilesPerGalon { get; set; }
        public double AccelerationTime { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public string Origin { get; set; }
        public double Weight { get; set; }

        public Car() { }

        public Car(string model, double milesPerGalon, double accelerationTime, int cylinders, double horsePower, string origin, double weight)
        {
            Model = model;
            MilesPerGalon = milesPerGalon;
            AccelerationTime = accelerationTime;
            Cylinders = cylinders;
            HorsePower = horsePower;
            Origin = origin;
            Weight = weight;
        }
    }

}
