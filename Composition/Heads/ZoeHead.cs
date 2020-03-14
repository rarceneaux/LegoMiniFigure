using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Heads
{
    internal class ZoeHead
    {
        public LegoColor EyeColor { get; set; }
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }

        /*Method */
        public void Talk()
        {
            Console.WriteLine($" Zoe  says astronuat 'Tell my wife I love her very much {FacialExpression}");
        }

        public void EatPie(string typeOfPie)
        {
            if(typeOfPie == "apple")
                Console.WriteLine("MMM... Pie");
            else
                Console.WriteLine("Nope");
        }
    }

    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange
    }
}
