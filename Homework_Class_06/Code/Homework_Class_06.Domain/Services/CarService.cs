using Homework_Class_06.Domain.Data;
using Homework_Class_06.Domain.Models;

namespace Homework_Class_06.Domain.Services
{
    public static class CarService
    {
        public static List<Car> GetEuropeanCars() =>
            CarsData.Cars.Where(car => car.Origin == "Europe").ToList();

        public static List<Car> GetHighCylinderCars() =>
            CarsData.Cars.Where(car => car.Cylinders > 6).ToList();

        public static List<Car> GetFourCylinderHighHP() =>
            CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110).ToList();

        public static List<Car> GetMergedFilteredCars() =>
            GetHighCylinderCars().Concat(GetFourCylinderHighHP()).ToList();

        public static List<string> GetCountByOrigin() =>
            CarsData.Cars
            .GroupBy(car => car.Origin)
            .Select(group => $"{group.Key} {group.Count()} models")
            .ToList();

        public static (double Min, double Max, double Avg)? GetMpgStatsForPowerfulCars()
        {
            var cars = CarsData.Cars.Where(car => car.HorsePower > 200).ToList();
            if (cars.Count == 0) return null;

            return (
                cars.Min(car => car.MilesPerGalon),
                cars.Max(car => car.MilesPerGalon),
                cars.Average(car => car.MilesPerGalon)
            );
        }
    }
}
