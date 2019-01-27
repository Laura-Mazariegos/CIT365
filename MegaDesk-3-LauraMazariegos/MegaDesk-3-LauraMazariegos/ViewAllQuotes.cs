using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_3_LauraMazariegos
{
    
       

    

    
    public partial class ViewAllQuotes : Form
    {
        int numDrawers;
        double width;
        double height;
        double total;
        enum Express
        {
            three,
            five,
            seven
        };

        enum Material
        {
            Oak,
            Pine,
            Veneer,
            Laminate,
            Rosewood
        }

        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void heightInput_Click(object sender, EventArgs e)
        {
           
                
        }

        private void widthInput_Click(object sender, EventArgs e)
        {
            
        }

        private void drawersInput_Click(object sender, EventArgs e)
        {
            
            
        }

        private void materialInput_Click(object sender, EventArgs e)
        {
            
       
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            total = height * width + numDrawers  ;
        }
    }
}
