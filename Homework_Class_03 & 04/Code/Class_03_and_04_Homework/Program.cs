using Class_03_and_04_Homework.Domain;
using Class_03_and_04_Homework.Domain.Models;
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