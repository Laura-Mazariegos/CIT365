﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_3_LauraMazariegos
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
                var mainMenu = (MainMenu)Tag;
                mainMenu.Show();
                Close();            
        }
    }
}
