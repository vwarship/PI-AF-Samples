using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.AF;
using OSIsoft.AF.UnitsOfMeasure;

namespace AFSDKSamples
{
    class UOMManager
    {
        private PISystem piSystem;

        public UOMManager(PISystem piSystem)
        {
            this.piSystem = piSystem;
        }

        public void ShowAll()
        {
            foreach (UOMClass uomClass in piSystem.UOMDatabase.UOMClasses)
            {
                Console.WriteLine(uomClass.Name);
                foreach (UOM uom in uomClass.UOMs)
                {
                    Console.Write("  ");
                    Console.WriteLine(uom.Name);
                }
            }
        }
    }
}
