using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using Utilities.Documents;
using Utilities;

namespace Applications.Applications.Payroll
{
    public partial class Payroll_Main : Applications.Payroll.Payroll_Template
    {
        public Payroll_Main()
        {
            InitializeComponent();
        }
        public Payroll_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
  

     }
}
