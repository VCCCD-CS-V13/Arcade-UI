using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARPDICEGAME
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
            else
                Application.Exit();
        }
        private void DiceButton_Click(object sender, EventArgs e)
        {
            string Player1Name = textBox1.Text, Player2Name = textBox2.Text;
            Form1 f1 = new Form1(Player1Name, Player2Name);
            f1.Show();
            this.Hide();
        }

        private void TIC_Click(object sender, EventArgs e)
        {
            Hide();
            TicTacToe.Form4 form4 = new TicTacToe.Form4();
            form4.ShowDialog();
            form4.Dispose();
        }

        private void PongButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Single Player Game Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                HellPong.Form6 form6 = new HellPong.Form6();
                form6.ShowDialog();
                form6.Dispose();
            }
        }
    }
}
