﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigPappa : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are diving a big pappa!!!");
        }
    }
}
