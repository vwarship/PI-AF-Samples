using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.AF;
using OSIsoft.AF.Asset;

namespace AFSDKSamples
{
    class ElementManager
    {
        private AFDatabase database;
        private int depth = 0;

        public ElementManager(AFDatabase database)
        {
            this.database = database;
        }

        public void Add(string name)
        {
            AFElement element = database.Elements.Add(name);
            element.CheckIn();
        }

        public void ShowElements(AFElements elements)
        {
            ++depth;

            foreach (AFElement e in elements)
            {
                WriteElementDepthString();
                Console.WriteLine("Element: {0}", e.Name);
                ShowAttributes(e.Attributes);

                ShowElements(e.Elements);
            }

            --depth;
        }

        private void ShowAttributes(AFAttributes attrs)
        {
            foreach (AFAttribute attr in attrs)
            {
                ShowAttribute(attr);
            }
        }

        private void ShowAttribute(AFAttribute attr)
        {
            WriteAttributeDepthString();
            Console.WriteLine("-Name：{0}", attr.Name);
            WriteAttributeDepthString();
            Console.WriteLine("Value：{0}", attr.GetValue());
            WriteAttributeDepthString();
            Console.WriteLine("Type: {0}", attr.Type);
            if (attr.DataReference != null)
            {
                WriteAttributeDepthString();
                Console.WriteLine("DataReference: {0}", attr.DataReference.Name);
                WriteAttributeDepthString();
                Console.WriteLine("DataReference ConfigString: {0}", attr.ConfigString);
            }
        }

        private string MakeSpace(int n)
        {
            return new String(' ', n * 2);
        }

        private void WriteElementDepthString()
        {
            Console.Write(MakeSpace(depth));
        }

        private void WriteAttributeDepthString()
        {
            Console.Write("  ");
            Console.Write(MakeSpace(depth));
        }

    }
}
