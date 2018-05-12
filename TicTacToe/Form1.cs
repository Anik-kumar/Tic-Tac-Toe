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
        bool turn = true;
        int p1 = 0;
        int p2 = 0;
        



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (turn)
            {
                btn.Text = "X";
                displayTurnLabel.Text = "Player 2";
                
            }
            else
            {
                btn.Text = "O";
                displayTurnLabel.Text = "Player 1";
                

            }

            turn = !turn;
            btn.Enabled = false;
            checkIt();

        }


        

        public void checkIt()
        {
            bool winner = false;

            
            if((button1.Text == button2.Text) && (button2.Text == button3.Text) 
                && button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                winner = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text
                && button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                winner = true;

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text
                && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                winner = true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text
                && button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                winner = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text
                && button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                winner = true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text
                && button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                winner = true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text
                && button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                winner = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text
                && button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                winner = true;
            }


            if (winner)
            {
                if (!turn)
                {
                    MessageBox.Show("Player 1 WINNER");
                    p1++;
                    clearGame();
                    player1scoreBox.Text = p1.ToString();


                }
                else
                {
                    MessageBox.Show("Player 2 WINNER");
                    p2++;
                    clearGame();
                    player2scoreBox.Text = p2.ToString();

                }
            }

        }


        public void clearGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


            turn = true;
            displayTurnLabel.Text = "Player 1";
        }


        public void reset()
        {
            clearGame();
            turn = true;
            p1 = 0;
            p2 = 0;
            player1scoreBox.Text = p1.ToString();
            player2scoreBox.Text = p2.ToString();
            displayTurnLabel.Text = "Player 1";

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }




    
}
