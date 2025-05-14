using Class_04_Homework.Domain.Utils;
using Class_04_Homework.Domain.Vehicles;

PrintInConsole.Print("Printing a string!");
PrintInConsole.Print(42);

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<string> strings = new List<string> { "Hello", "World" };
PrintInConsole.PrintCollection(numbers);
PrintInConsole.PrintCollection(strings);


Car car = new();
MotorBike motorBike = new();
Boat boat = new();
Airplane plane = new();


car.Drive();
car.DisplayInfo();
motorBike.Wheelie();
motorBike.DisplayInfo();
boat.Sail();
boat.DisplayInfo();
plane.Fly();
plane.DisplayInfo();