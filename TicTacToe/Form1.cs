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
        string Player1 = "Player 1";
        string Player2 = "Player 2";

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
            if (turn)
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
            if ((buttonA1.Text == buttonA2.Text) && (buttonA2.Text == buttonA3.Text) && !buttonA1.Enabled)
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
            else if ((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && !buttonA1.Enabled)
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

            if (Winner)
            {
                DisableAll();

                string winc;
                if (turn)
                {
                    winc = Player2;
                    labelOwin.Text = (Int32.Parse(labelOwin.Text) + 1).ToString();
                }
                else
                {
                    winc = Player1;
                    labelXwin.Text = (Int32.Parse(labelXwin.Text) + 1).ToString();
                }

                MessageBox.Show(winc + " Wins!", "Winner");
            }
            else
            {
                if (turncount == 9)
                {
                    MessageBox.Show(" Tie!", "No winner");
                    labelTIE.Text = (Int32.Parse(labelTIE.Text) + 1).ToString();
                }
                    
            }
        }

        private void DisableAll()
        {
            Button[] buttonS = new Button[] { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };
            try
            {
                foreach (Button i in buttonS)
                {
                    Button b = (Button)i;
                    b.Enabled = false;
                }
            }
            catch (Exception)
            {
                //do nothing, it thinks the menu strip is a button
            }

            button1.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turncount = 0;
            turn = true;

            foreach (Control i in Controls)
            {
                try
                {
                    Button b = (Button)i;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch (Exception)
                {

                }

            }

        }



        private void Benter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "x";
                }
                else
                {
                    b.Text = "o";
                }
            }
            else
            {

            }

        }

        private void Bleave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelXwin.Text = "0";
            labelOwin.Text = "0";
            labelTIE.Text = "0";
            newGameToolStripMenuItem_Click(sender, e);


        }

        private void textBox1P1_TextChanged(object sender, EventArgs e)
        {
            Player1 = textBox1P1.Text;
        }

        private void textBox2P2_TextChanged(object sender, EventArgs e)
        {
            Player2 = textBox2P2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newGameToolStripMenuItem_Click(sender, e);
        }
    }
}
