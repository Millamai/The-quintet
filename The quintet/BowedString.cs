using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_quintet
{
    public class BowedString : StringInstrument
    {
        public BowedString(int numberOfStrings) : base(numberOfStrings)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "En stryger (eller et strygeinstrument) er et strengeinstrument, der spilles med bue af træ, hvorpå der er påspændt hestehår, som gnides med harpiks.";
        }
    }
}
