﻿using AdminRentalUI.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRentalUI.User_Control_for_Payment
{
    public partial class khalti : UserControl
    {
        public khalti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rulesAndRegulationcs rr = new rulesAndRegulationcs();
            rr.ShowDialog();
            this.Show();
        }
    }
}