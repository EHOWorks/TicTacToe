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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(p1.Text, p2.Text);
            Form f1 = new Form1();
            if (!p1.Text.Equals("") && !p2.Text.Equals(""))
            {
                this.Hide();
                f1.Show();
            }
            else
                MessageBox.Show("Veuillez rentrez le nom des deux joueurs !");
            
        }

        private void P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                play_button.PerformClick();
        }
    }
}
