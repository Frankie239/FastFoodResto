﻿using System;
using System.Windows.Forms;
using Controllers;

namespace MasterForm
{
    public partial class MasterForm : Form
    {
         string FormID = string.Empty;
        public MasterForm()
        {
            InitializeComponent();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewHamb.Dock = DockStyle.Fill;
            dataGridViewHamb.AutoGenerateColumns = true;
            
            BindingSource bs = new BindingSource();

            bs.DataSource = Dummy.Clients;

            dataGridViewHamb.DataSource = bs;
            
            
            
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            


        }

        private void dataGridViewHamb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
