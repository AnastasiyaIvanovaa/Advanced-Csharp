﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo,Tires[] tires)
        {
            Model=model;
            Engine=engine;
            Cargo=cargo;
            Tire = tires;
        }
        public string Model { get; set; }

        public Engine Engine{ get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tire { get; set; }

    }
}
