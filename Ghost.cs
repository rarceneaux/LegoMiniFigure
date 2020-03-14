﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    internal class Ghost
    {
        public bool Friendly { get; set; } 
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; private set; }

        public DateTime DeathDay { get;}

        public Ghost (string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} does a spook at {hauntingLocation}");
        }
        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;
            
            Console.WriteLine($"{Name} does a sppok at {HauntingLocation}");
        }


    }
}
