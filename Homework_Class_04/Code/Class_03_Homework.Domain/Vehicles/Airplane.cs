﻿using Class_04_Homework.Domain.Models;
namespace Class_04_Homework.Domain.Vehicles

{
    public class Airplane : Vehicle
    {
        public Airplane() { }
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }
    }
}
