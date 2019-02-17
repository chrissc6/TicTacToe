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
        bool ComputerActive = false; // computer ai

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

            if ((!turn) && (ComputerActive))
            {
                ComputerAiMove();
            }
        }

        private void ComputerAiMove()
        {
            //win - get tic tac toe
            //save - block x win
            //strat - go for corner
            //start - go for center
            //else - go for open space

            Button move = null;
            //move = LookAnySpace();

            move = LookWin("O");
            if (move == null)
            {
                move = LookBlock("X");
                if (move == null)
                {
                    move = LookCorner();
                    if (move == null)
                    {
                        move = LookAnySpace();
                    }
                }
            }

            move.PerformClick();
        }

        private Button LookAnySpace()
        {
            Button[] buttonS = new Button[] { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };

            foreach (Button i in buttonS)
            {
                if(i.Enabled == true)
                {
                    return i;
                }
            }

            return null;
        }

        private Button LookCorner()
        {
            if (buttonA1.Text == "")
                return buttonA1;
            if (buttonA3.Text == "")
                return buttonA3;
            if (buttonC1.Text == "")
                return buttonC1;
            if (buttonC3.Text == "")
                return buttonC3;

            else
            {
                return null;
            }
        }

        private Button LookBlock(string v)
        {
            Button test;

            test = LookWin(v);

            if (test == null)
            {
                return null;
            }
            else
            {
                return test;
            }
        }

        private Button LookWin(string v)
        {
            //horizontal
            if ((buttonA1.Text == v) && (buttonA2.Text == v) && (buttonA3.Text == ""))
                return buttonA3;
            if ((buttonA1.Text == v) && (buttonA2.Text == "") && (buttonA3.Text == v))
                return buttonA2;
            if ((buttonA1.Text == "") && (buttonA2.Text == v) && (buttonA3.Text == v))
                return buttonA1;
            if ((buttonB1.Text == v) && (buttonB2.Text == v) && (buttonB3.Text == ""))
                return buttonB3;
            if ((buttonB1.Text == v) && (buttonB2.Text == "") && (buttonB3.Text == v))
                return buttonB2;
            if ((buttonB1.Text == "") && (buttonB2.Text == v) && (buttonB3.Text == v))
                return buttonB1;
            if ((buttonC1.Text == v) && (buttonC2.Text == v) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonC1.Text == v) && (buttonC2.Text == "") && (buttonC3.Text == v))
                return buttonC2;
            if ((buttonC1.Text == "") && (buttonC2.Text == v) && (buttonC3.Text == v))
                return buttonC1;

            //vertical
            if ((buttonA1.Text == v) && (buttonB1.Text == v) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonA1.Text == v) && (buttonB1.Text == "") && (buttonC1.Text == v))
                return buttonB1;
            if ((buttonA1.Text == "") && (buttonB1.Text == v) && (buttonC1.Text == v))
                return buttonA1;
            if ((buttonA2.Text == v) && (buttonB2.Text == v) && (buttonC2.Text == ""))
                return buttonC2;
            if ((buttonA2.Text == v) && (buttonB2.Text == "") && (buttonC2.Text == v))
                return buttonB2;
            if ((buttonA2.Text == "") && (buttonB2.Text == v) && (buttonC2.Text == v))
                return buttonA2;
            if ((buttonA3.Text == v) && (buttonB3.Text == v) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonA3.Text == v) && (buttonB3.Text == "") && (buttonC3.Text == v))
                return buttonB3;
            if ((buttonA3.Text == "") && (buttonB3.Text == v) && (buttonC3.Text == v))
                return buttonA3;

            //diagonal
            if ((buttonA1.Text == v) && (buttonB2.Text == v) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonA1.Text == v) && (buttonB2.Text == "") && (buttonC3.Text == v))
                return buttonB2;
            if ((buttonA1.Text == "") && (buttonB2.Text == v) && (buttonC3.Text == v))
                return buttonA1;
            if ((buttonA3.Text == v) && (buttonB2.Text == v) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonA3.Text == v) && (buttonB2.Text == "") && (buttonC1.Text == v))
                return buttonB2;
            if ((buttonA3.Text == "") && (buttonB2.Text == v) && (buttonC1.Text == v))
                return buttonA3;

            else
            {
                return null;
            }
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
            Button[] buttonS = new Button[] { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };
            turncount = 0;
            turn = true;

            foreach (Button i in buttonS)
            {
                try
                {
                    i.Enabled = true;
                    i.Text = "";
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
            if (textBox2P2.Text.ToUpper() == "COMPUTER")
            {
                ComputerActive = true;
                Player2 = textBox2P2.Text;
            }
            else
            {
                Player2 = textBox2P2.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newGameToolStripMenuItem_Click(sender, e);
        }

        private void setDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player1 = "Player 1";
            textBox1P1.Text = Player1;
            Player2 = "Player 2";
            textBox2P2.Text = Player2;
            ComputerActive = false;
        }

        private void playerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player2 = "Computer";
            textBox2P2.Text = Player2;
            ComputerActive = true;
        }

        private void playerModeDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setDefaultToolStripMenuItem_Click(sender, e);
        }

        private void easterEggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player2 = "Computer";
            textBox2P2.Text = Player2;
            ComputerActive = true;
            MessageBox.Show(" My 1st AI go easy on em", "Easter Egg");
        }
    }
}
