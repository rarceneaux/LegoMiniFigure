using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Legs
{
    class AstronautLegs
    {
        public bool HasPants { get; set; }
        public ShoeType Shoes { get; set; }

        private Random _rng = new Random(4);

        public void Walk(int steps)
        {
            Console.WriteLine($"The astronaut legs moonwalked {steps} steps" );
        }

        public int Jump()
        {
            var heightOfJump = new Random(4).Next();

            return heightOfJump;
        }
    }

    enum ShoeType
    {
        None,
        Boots,
        FlipFlops,
    }
}
