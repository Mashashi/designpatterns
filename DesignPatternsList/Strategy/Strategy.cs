using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontFormatter
{
  
    abstract class ColorApplier
    {

        public abstract String applyColor();

    }

    class DegradeEffectColorApplier : ColorApplier
    {

        public override String applyColor()
        {
            return "Degrade Color";
        }

    }

    class FastSwitchColorApplier : ColorApplier
    {

        public override String applyColor()
        {
            return "Harsh switch";
        }

    }

    class FontFormatter {

        public ColorApplier colorApplier;

        public FontFormatter() {
            colorApplier = new DegradeEffectColorApplier();
        }

    }

    class Client
    {

        public static void Main(String[] arg)
        {
            FontFormatter f = new FontFormatter();
            System.Console.WriteLine(f.colorApplier());
            System.Console.ReadLine();
        }

    }

}
