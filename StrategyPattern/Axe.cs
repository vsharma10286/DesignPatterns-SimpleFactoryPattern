﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
