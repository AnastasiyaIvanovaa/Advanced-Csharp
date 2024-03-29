﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make,string model,int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make,string model,int year,double fuelQuantity, double fuelConsumption)
            :this(make,model,year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public string Make { get; set; }

        public string Model { get; set; }
        
        public int Year { get; set; }

        public double FuelQuantity { get; set; }
        
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity-(distance*FuelConsumption)>=0)
            {
                FuelQuantity -= (distance * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel:{FuelQuantity:F2}";
        }
    }
}
