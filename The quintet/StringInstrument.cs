using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class StringInstrument : Instrument
    {
        int numberOfStrings;
        protected int NumberOfStrings { get => numberOfStrings; private set => numberOfStrings = value; }

        public StringInstrument(int numberOfStrings)
        {
            NumberOfStrings = numberOfStrings;
        }


        public override string ToString()
        {
            return base.ToString() + "Strengeinstrumenter er instrumenter, hvor lyden frembringes af streng(e), der vibrerer og frembringer lyd, oftest forstærket af en resonanskasse. \n";
        }
    }
}
