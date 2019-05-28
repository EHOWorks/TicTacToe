using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Design;

namespace TicTacToe
{
    public partial class Form1 : MetroForm
    {
        bool turn = true; // true = X turn ; false = O turn
        int turn_count = 0;
        static String player1, player2;

        public Form1()
        {
            InitializeComponent();
        }
        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = player1 + " Gagne";
            label2.Text = player2 + " Gagne";
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zayneb Gaouzi, Abdoulaye Sadio Barry, El Hanchi Othmane", "Tic Tac Toe About");
        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X"; 
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {

            bool there_is_a_winner = false;

            //horizontal checks 
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                there_is_a_winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                there_is_a_winner = true;

            //vertical checks 
            if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                there_is_a_winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                there_is_a_winner = true;

            //diagonal checks 
            if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                    winner = player2;
                }
                else
                {
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    winner = player1;
                }
                   
                MessageBox.Show(winner + " Gagne ! :) " , " Victory ");
            }else if (turn_count == 9)
            {
                draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                MessageBox.Show("Egalite ! :( " , " Draw " );
            }
               
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button && c.Text.Equals(""))
                    {
                        Button b = (Button) c;
                        b.Enabled = false;
                    }
                    
                }
            }
            catch{ }
          
        }
        private void enableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button  && ( c.Text.Equals("") || c.Text.Equals("X") || c.Text.Equals("O")) )
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }              
                }
            }
            catch { }

        }


        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            enableButtons();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
     
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            enableButtons();
        }

        private void MenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Menu();
            f2.Show();
            this.Hide();        
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
