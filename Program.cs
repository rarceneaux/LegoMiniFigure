using System;

namespace LegoMiniFigure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Today);
            casper.Friendly = true;
            casper.Haunt("The Hood");

          
        }
    }
}
