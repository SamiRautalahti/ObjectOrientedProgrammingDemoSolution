﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    class Car
    {
        public string color;
        public string brand;
        public int speed;

        public Car()
        {
            this.color = string.Empty;
            this.brand = string.Empty;
            this.speed = 0;
            //AskData
        }
        
        public void AskData()
        {
            Console.Write("Auton väri? ");
            this.color = Console.ReadLine();
            Console.Write("Anna auton merkki? ");
            this.brand = Console.ReadLine();
            Console.Write("Anna auton nopeus? ");
            this.speed = int.Parse(Console.ReadLine());

        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {this.brand}, väri on nyt {this.color} ja nopeus on {this.speed}");

        }
        public void Accelerate(int change)
        {
            
            
        }

        public void Brake()
        {

        }
    }
}
