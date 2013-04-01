using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.AF;
using OSIsoft.AF.Asset;

namespace AFSDKSamples
{
    class EnumSetManager
    {
        private AFDatabase database;
        private int depth = 0;

        public EnumSetManager(AFDatabase database)
        {
            this.database = database;
        }

        public void ShowAll()
        {
            foreach (AFEnumerationSet enumSet in database.EnumerationSets)
            {
                foreach (AFEnumerationValue value in enumSet)
                {
                    Console.WriteLine("{0} = {1}", value.Name, value.Value);
                }
            }
        }

    }
}
