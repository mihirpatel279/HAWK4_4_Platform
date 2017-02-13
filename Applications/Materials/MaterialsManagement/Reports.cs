using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Materials.MaterialsManagement
{
    public partial class Reports : Applications.Materials.MaterialsManagement.MaterialsManagement_Template
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Applications.Materials.MaterialsManagement.Top5SoldMaterials report1 = new Applications.Materials.MaterialsManagement.Top5SoldMaterials();
            CrystalReport_Viewer cr = new CrystalReport_Viewer();
            cr.crystalReportViewer1.ReportSource = report1;
            cr.Show();
        }
    }
}
