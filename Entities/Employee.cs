﻿using System;
using System.Collections.Generic;


namespace HerançaEPolimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }//horas trabalhadas pelo func.
        public double ValuePerHour { get; set; } //valor por horas

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
