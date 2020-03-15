using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Heads
{
    internal class DragonHead
    {
        public int NumberOfTeeth { get; set; }
        public bool Spiked { get; set; }
        public LegoColor Color { get; set; }
        public BreathType BreathType { get; set; }

        public void Talk()
        {
            Console.WriteLine("You not from my hood get from around herrreee.");
        }

        public void Breathe()
        {
            Console.WriteLine( $"Dragon Head attacks with {BreathType} breath");
        }
    }

   enum BreathType
    {
        Stanky,
        Fire,
        Poison,
        Ice
    }
}

