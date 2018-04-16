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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Player1Name=textBox1.Text, Player2Name=textBox2.Text;
            Form1 f1 = new Form1(Player1Name,Player2Name);
            f1.Show();
            this.Hide();

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
            else
                Application.Exit();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                button1.Enabled = true;
            }
        }
    }
}
