using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Torsos
{
    internal class AstronautTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }


        public override void Flex()
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
        public override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("Exhale, Inhale..");
        }
    }
   
}
