using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LauraMazariegos_MathQuiz
{
    public partial class Form1 : Form
    {
        // random number variable
        Random randomizer = new Random();
       

        // initialize addition variables
        int addend1;
        int addend2;

        //initialize subtraction variables
        int minuend;
        int subtrahend;

        // initialize multiplication variables
        int multipicand;
        int multiplier;

        //initialize the division variables
        int dividend;
        int divisor;

        // initialize time remaining variable
        int timeLeft;


        // heart of the program 
        public void StartTheQuiz()
        {
            // set the addition variables to 50 max
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //print the numbers on the screen
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //set the starting value of sum
            sum.Value = 0;

            //set the subtraction variables to max 100, no negatives
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            // print the numbers to the screen
            minusLeft.Text = minuend.ToString();
            minusRight.Text = subtrahend.ToString();

            // set the starting value of difference
            difference.Value = 0;

            //set the multiplication variables from 2 to 10
            multipicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            //print the numbers to the screen
            multiplyLeft.Text = multipicand.ToString();
            multiplyRight.Text = multiplier.ToString();

            //set the starting value of the product
            product.Value = 0;

            //set the division variables from 2 to 10
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            
            //print the numbers to the screen
            divideLeft.Text = dividend.ToString();
            divideRight.Text = divisor.ToString();
           
            //set the starting value of the quotient
            quotient.Value = 0;

            // timer set to 30 seconds and start timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }
        public Form1()
        {
            InitializeComponent();
        }

        // start button method
        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            startButton.BackColor = Color.Gray;
           
        }

        // Let's check the answers and verify time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //correct answer message box
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
                startButton.BackColor = Color.Green;
                timeLabel.Text = timeLeft + " seconds";

            }

            else if (timeLeft > 0)
            {
                //timer countdown
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
                
                if (timeLeft < 6)
                {
                    timeLabel.BackColor = Color.Red;
                }
                else
                {
                    timeLabel.BackColor = Color.Yellow;
                }
            }

            else
            {
                // quiz timed out
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                // verify addition
                sum.Value = addend1 + addend2;
                //verify subtraction
                difference.Value = minuend - subtrahend;
                //verify multiplication
                product.Value = multipicand * multiplier;
                //verify division
                quotient.Value = dividend / divisor;

                startButton.Enabled = true;
                startButton.BackColor = Color.Green;
            }

            bool CheckTheAnswer()
            {
                // check the answers to the addition 
                if ((addend1 + addend2 == sum.Value)
                    // subtraction
                    && (minuend - subtrahend == difference.Value)
                    //multiplication
                    && (multipicand * multiplier == product.Value)
                    //division
                    && (dividend / divisor == quotient.Value))
                    return true;
                else
                    return false;
        }   
        }
        
        // let's fix the number input issue
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
            
        
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           date.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }
    }
} //<div>Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" 
