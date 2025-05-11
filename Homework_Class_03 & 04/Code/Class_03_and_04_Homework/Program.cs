using Class_03_and_04_Homework.Domain;
using Class_03_and_04_Homework.Domain.Models;
using Class_03_and_04_Homework.Domain.Vehicles;


Console.WriteLine("Search Results:");
List<User> results = UserDatabase.Search(name:"Kire");

foreach (User user in results)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}


Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();