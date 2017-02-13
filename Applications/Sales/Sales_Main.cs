using Applications.Applications.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales
{
    public partial class Sales_Main : Applications.Sales.Sales_Template
    {
        public Sales_Main()
        {
            InitializeComponent();
        }
       public Sales_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
 
    }
}
