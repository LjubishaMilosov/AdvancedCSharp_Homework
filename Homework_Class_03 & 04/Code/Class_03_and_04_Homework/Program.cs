using Class_03_and_04_Homework.Domain;
using Class_03_and_04_Homework.Domain.Models;
using Class_03_and_04_Homework.Domain.Utils;
using Class_03_and_04_Homework.Domain.Vehicles;


Console.WriteLine("Search Results:");
List<User> results = UserDatabase.Search(name:"Kire");

foreach (User user in results)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();


PrintInConsole.Print("Printing a string!");
PrintInConsole.Print(42);

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<string> strings = new List<string> { "Hello", "World" };
PrintInConsole.PrintCollection(numbers);
PrintInConsole.PrintCollection(strings);


Car car1 = new();
MotorBike motorBike1 = new();
Boat boat1 = new();
Airplane plane1 = new();

car1.Drive();
car1.DisplayInfo();
motorBike1.Wheelie();
motorBike1.DisplayInfo();
boat1.Sail();
boat1.DisplayInfo();
plane1.Fly();
plane1.DisplayInfo();