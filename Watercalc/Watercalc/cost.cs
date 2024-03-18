﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Watercalc.Main_interface;

namespace Watercalc
{
    public partial class cost : Form
    {
        public cost()
        {
            InitializeComponent();
            if (night.nightmode)
            {
                this.BackColor = Color.Black;
                btn_exit.BackColor = Color.Black;
                ForeColor = Color.White;
            }
            if (!night.nightmode)
            {
                this.BackColor = SystemColors.Control;
                btn_exit.BackColor= SystemColors.Control;
                ForeColor= Color.Black;
            }
        }

        private void cost_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
