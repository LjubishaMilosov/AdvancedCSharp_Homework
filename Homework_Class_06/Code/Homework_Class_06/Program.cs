using Homework_Class_06.Domain.Services;


var europeanCars = CarService.GetEuropeanCars();
Console.WriteLine("\n 1. Cars from Europe: \n");
foreach (var car in europeanCars)
    Console.WriteLine(car.Model);


var mergedResults = CarService.GetMergedFilteredCars();
Console.WriteLine("\n 2. Merged filtered cars: \n");
foreach (var car in mergedResults)
    Console.WriteLine(car.Model);

var carsCountByOrigin = CarService.GetCountByOrigin();
Console.WriteLine("\n 3. Car count by origin: \n");
foreach(var origin in carsCountByOrigin)
    Console.WriteLine(origin);


var mpgStats = CarService.GetMpgStatsForPowerfulCars();
Console.WriteLine("\n 4. MPG Stats for Cars with >200 HP: \n");
if (mpgStats.HasValue)
{
    Console.WriteLine($"Lowest MPG: {mpgStats.Value.Min}");
    Console.WriteLine($"Highest MPG: {mpgStats.Value.Max}");
    Console.WriteLine($"Average MPG: {mpgStats.Value.Avg}");
}
