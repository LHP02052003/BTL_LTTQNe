﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQNe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			FormTimKiem otherForm = new FormTimKiem();
			otherForm.Show();
			this.Hide();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            FormTimkiemMonAn otherForm = new FormTimkiemMonAn();
            otherForm.Show();
            this.Hide();
        }
    }
}
