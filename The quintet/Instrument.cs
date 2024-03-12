using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class Instrument
    {
      
        public override string ToString()
        {
            return "Et musikinstrument er et objekt, der bruges af en musiker til at frembringe musik med. \n";
        }

        //Denne metode erklæres virtuel, hvilke giver subklasserne mulighed for at overskrive metoden
        public virtual void Play() 
        { 
        
        }
    }
}
