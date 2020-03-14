using System;
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
    }

    internal enum HandType
    {
        Human,
        Robot,
        Baby,
        Tentacles,
        CanadaArm,
        XBuster
    }
}
