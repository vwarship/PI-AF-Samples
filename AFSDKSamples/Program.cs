using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.AF;

namespace AFSDKSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            PISystems piSystems = new PISystems();
            PISystem piSystem = piSystems.DefaultPISystem;
            AFDatabase database = piSystem.Databases["Samples"];

            Console.WriteLine("Show All Elements.");
            ElementManager elementManager = new ElementManager(database);
            Console.WriteLine("Root");
            elementManager.ShowElements(database.Elements);

            Console.WriteLine("Show All UOMs.");
            UOMManager uomManager = new UOMManager(piSystem);
            uomManager.ShowAll();

            Console.WriteLine("Show All Tables.");
            TableManager tableManager = new TableManager(database);
            tableManager.ShowAll();

            Console.WriteLine("Show All Enumeration Set.");
            EnumSetManager enumSetManager = new EnumSetManager(database);
            enumSetManager.ShowAll();
        }
    }
}
