﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure.Composition.Torsos
{
    abstract class TorsoBase
    {
        public bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public abstract void Flex();

        public virtual void Breathe()
        {
            Console.WriteLine("Inhale, Exhale...");
        }


    }
}
