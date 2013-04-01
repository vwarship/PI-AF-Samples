using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OSIsoft.AF;
using OSIsoft.AF.UI;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Modeling;
using OSIsoft.AF.Time;
using OSIsoft.AF.UnitsOfMeasure;

namespace Elements
{
    public partial class MyPISystemExplorer : Form
    {
        private PISystem piSystem;

        public MyPISystemExplorer()
        {
            InitializeComponent();
            afDatabasePicker.SystemPicker = piSystemPicker;
        }

        private void databaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            afTreeView.AFRoot = afDatabasePicker.AFDatabase;
        }

        private void afDatabasePicker_SelectionChange(object sender, SelectionChangeEventArgs e)
        {
            afTreeView.AFRoot = afDatabasePicker.AFDatabase;
        }

        private void afTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            afViewControl.AFSetObject(afTreeView.AFSelection, null, null, null);
        }

    }
}
