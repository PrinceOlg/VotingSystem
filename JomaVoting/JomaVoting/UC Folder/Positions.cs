﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JomaVoting
{
    public partial class Positions : UserControl
    {
        public Positions()
        {
            InitializeComponent();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            AddPosition addPosition = new AddPosition();
            addPosition.Show();
        }
    }
}