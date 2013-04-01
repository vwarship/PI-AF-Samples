using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.AF;
using OSIsoft.AF.Asset;

namespace AFSDKSamples
{
    class TableManager
    {
        private AFDatabase database;

        public TableManager(AFDatabase database)
        {
            this.database = database;
        }

        public void ShowAll()
        {
            foreach (AFTable table in database.Tables)
            {
                Console.WriteLine("Table Name: {0}", table.Name);
                foreach (DataRow row in table.Table.Select())
                {
                    foreach (DataColumn column in table.Table.Columns)
                        Console.Write("\t{0}({1})", column.ColumnName, row[column]);
                    Console.WriteLine();
                }
            }
        }
    }
}
