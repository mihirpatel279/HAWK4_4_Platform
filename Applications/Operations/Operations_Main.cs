﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations
{
    public partial class Operations_Main : Applications.Operations.Operations_Template
    {
        public Operations_Main()
        {
            InitializeComponent();
        }
               public Operations_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

     }
}
