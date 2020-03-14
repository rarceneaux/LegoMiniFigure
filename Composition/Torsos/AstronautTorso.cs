﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Torsos
{
    internal class AstronautTorso
    {
        public int NumberOfArms { get; set; }
        public bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show. Pew Pew!");
            }
            else
            {
                Console.WriteLine("Wired flex, but ok.");
            }
        }
    }

    enum HandType
    {
        Human,
        Robot,
        Baby,
        Tentacles,
        CanadaArm,
        XBuster
    }
}
