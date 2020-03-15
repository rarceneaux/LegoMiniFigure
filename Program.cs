using System;
using LegoMiniFigure.Composition.Heads;
using LegoMiniFigure.Composition.Legs;
using LegoMiniFigure.Composition.Torsos;

namespace LegoMiniFigure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var atorso = new DadBodTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var dtorso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            atorso.Breathe();
            dtorso.Breathe();
            atorso.HandType = HandType.Baby;
            dtorso.ChiseledAbs = false;



            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, dtorso, legs); 

            astronaut.DoYourJob(100);

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;
            casper.Haunt("The Hood");

          
        }
    }
}
