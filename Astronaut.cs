using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    internal enum Location
    {
        Earth, 
        Space,
        SpaceStation
    }

    internal class Astronaut
    {
        /* created properties*/
        /*Changed location */
        public Location Location { get; set; }
 
        public bool SuitedUp => Name != "Space Person"; 
        /*expression bodied property determine the value of a property*/
        /*public bool SuitedUp { get; set; }*/

            /*Read Only Property*/
        public string Name { get; } 

        //Public Property with a private setter
        public string Job { get; private set; }
        public string OxygenLevel { private get; set; }


        /*this is an Constructor have to have the same name as the class, if you have parameters on it it must have them in program.cs when making copy */
         public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }
        /*Creating a Method for the class*/
        public void DoYourJob()
        {
            Console.WriteLine($"{Name} Doing all my {Job} duties...");
        }
    }
}
