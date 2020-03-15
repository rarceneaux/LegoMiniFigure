﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Legs
{
    internal class BabyLegs
    {
        public bool CanWalk { get; set; }
        public int NumberOfRolls { get; set; }
        public bool IsClumsy => true;
        public bool HasPants { get; set; }

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk around{steps} and then fall down");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with the power of {NumberOfRolls}");
        }
    }

}
