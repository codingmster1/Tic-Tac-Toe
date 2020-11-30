using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Form
{
    public partial class newGame : Form
    {
        public newGame()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void A12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                if(CheckDraw()==true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }
                if(CheckWinner()==true)
                {
                    if(button.Text=="X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("0 Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X:" + s1;
            OWin.Text = "O:" + s2;
            Draws.Text = "Draw: " + sd;
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A12.Text = A13.Text = A14.Text = A15.Text = A16.Text = A17.Text = A17.Text = A18.Text = A19.Text =
                A20.Text = "";
            XWin.Text = "X:" + s1;
            OWin.Text = "O:" + s2;
            Draws.Text = "Draw: " + sd;
        }

        private void newGame1_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if ((turns == 9)&&CheckWinner() ==false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //horizontal buttons
            if ((A12.Text == A13.Text) && (A13.Text == A14.Text) && A12.Text != "")
                return true;
            else if ((A14.Text == A15.Text) && (A15.Text == A16.Text) && A14.Text != "")
                return true;
            else if ((A15.Text == A16.Text) && (A16.Text == A17.Text) && A15.Text != "")
                return true;


            //vertical buttons

            if ((A12.Text == A15.Text) && (A15.Text == A18.Text) && A12.Text != "")
                return true;
            else if ((A13.Text == A16.Text) && (A16.Text == A19.Text) && A13.Text != "")
                return true;
            else if ((A14.Text == A17.Text) && (A17.Text == A20.Text) && A14.Text != "")
                return true;

            //diagonal checks
            if ((A12.Text == A16.Text) && (A16.Text == A20.Text) && A12.Text != "")
                return true;
            else if ((A14.Text == A16.Text) && (A16.Text == A18.Text) && A14.Text != "")
                return true;
            else
                return false;


        }

        private void reset2_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
