using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool turn = true; //true player 1 turn, false player 2 turn 
        int turncount = 0;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Chris C", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            turncount++;

            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn; //switch turn
            b.Enabled = false; //turning button off after click
            WinCheck();
        }

        private void WinCheck()
        {
            bool Winner = false;

            //horizontal
            if((buttonA1.Text == buttonA2.Text) && (buttonA2.Text == buttonA3.Text) && !buttonA1.Enabled)
            {
                Winner = true;
            }
            else if ((buttonB1.Text == buttonB2.Text) && (buttonB2.Text == buttonB3.Text) && !buttonB1.Enabled)
            {
                Winner = true;
            }
            else if ((buttonC1.Text == buttonC2.Text) && (buttonC2.Text == buttonC3.Text) && !buttonC1.Enabled)
            {
                Winner = true;
            }
            //vertical
            else if((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && !buttonA1.Enabled)
            {
                Winner = true;
            }
            else if ((buttonA2.Text == buttonB2.Text) && (buttonB2.Text == buttonC2.Text) && !buttonA2.Enabled)
            {
                Winner = true;
            }
            else if ((buttonA3.Text == buttonB3.Text) && (buttonB3.Text == buttonC3.Text) && !buttonA3.Enabled)
            {
                Winner = true;
            }
            //diagonal
            else if ((buttonA1.Text == buttonB2.Text) && (buttonB2.Text == buttonC3.Text) && !buttonA1.Enabled)
            {
                Winner = true;
            }
            else if ((buttonA3.Text == buttonB2.Text) && (buttonB2.Text == buttonC1.Text) && !buttonA3.Enabled)
            {
                Winner = true;
            }

            if(Winner)
            {
                DisableAll();

                string winc = "";
                if(turn)
                {
                    winc = "O";
                }
                else
                {
                    winc = "X";
                }

                MessageBox.Show(winc + " Wins!", "Winner");
            }
            else
            {
                if(turncount >= 9)
                    MessageBox.Show(" Tie!", "No winner");
            }
        }

        private void DisableAll()
        {
            try
            {
                foreach (Control i in Controls)
                {
                    Button b = (Button)i;
                    b.Enabled = false;
                }
            }
            catch(Exception)
            {
                //do nothing, it thinks the menu strip is a button
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turncount = 0;
            turn = true;

            try
            {
                foreach (Control i in Controls)
                {
                    Button b = (Button)i;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch (Exception)
            {
                //do nothing, it thinks the menu strip is a button
            }
        }
    }
}
