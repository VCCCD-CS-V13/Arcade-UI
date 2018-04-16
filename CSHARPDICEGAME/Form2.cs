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
    public partial class Form1 : Form
    {
        Image[] diceImages;
        int[] dice;
        Random roll;
        int[] player1 = new int[4];
        int[] player2 = new int[4];
        int games = 0,count = 0, player1Count = 0, player2Count = 0, drawCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int[] RollDice()
        {
            dice = new int[4];
            roll = new Random();
            for (int i = 0; i < 4; i++)
            {
                dice[i] = roll.Next(1, 7);
            }
            return dice;
        }

        private void displayScore(PictureBox image1, PictureBox image2, PictureBox image3, PictureBox image4, int[] diceRoll, Label scoreLabel)
        {
            image1.Image = diceImages[diceRoll[0] - 1];
            image2.Image = diceImages[diceRoll[1] - 1];
            image3.Image = diceImages[diceRoll[2] - 1];
            image4.Image = diceImages[diceRoll[3] - 1];
            int playerscore = 0;
            for (int i = 0; i < 4; i++)
            {
                playerscore += diceRoll[i];
            }
            scoreLabel.Text = (" " + playerscore);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[6];
            diceImages[0] = Properties.Resources.Alea_1;
            diceImages[1] = Properties.Resources.Alea_2;
            diceImages[2] = Properties.Resources.Alea_3;
            diceImages[3] = Properties.Resources.Alea_4;
            diceImages[4] = Properties.Resources.Alea_5;
            diceImages[5] = Properties.Resources.Alea_6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayScore(pictureBox1, pictureBox2, pictureBox3, pictureBox4, RollDice(), label4);
            button1.Enabled = false;
            button2.Enabled = true;
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                games = 1;
            }
            else
                games = int.Parse(textBox1.Text);
            displayScore(pictureBox5, pictureBox6, pictureBox7, pictureBox8, RollDice(), label6);
            button2.Enabled = false;
            if (int.Parse(label4.Text) > int.Parse(label6.Text))
            {
                label3.Text = "Player 1 Wins";
                player1Count++;
            }
            else if (int.Parse(label4.Text) == int.Parse(label6.Text))
            {
                label3.Text = "DRAW";
                drawCount++;
            }
            else
            {
                label3.Text = "Player 2 Wins";
                player2Count++;
            }
            while (count < games)
            {
                button3.Enabled = true;
                break;
            }
            if (count == games)
            {
                if (player1Count > player2Count)
                    MessageBox.Show("PLAYER 1 WINS!!!");
                else if (player1Count == player2Count)
                    MessageBox.Show("DRAW!!!");
                else
                    MessageBox.Show("PLAYER 2 WINS!!!");
            }
            label7.Text = ("Player 1 Wins:" + player1Count);
            label8.Text = ("Player 2 Wins:" + player2Count);
            label5.Text = ("Draws:" + drawCount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false && button2.Enabled == false)
            {
                button1.Enabled = true;
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
            }
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false && button2.Enabled == false)
            {
                games = 0;
                count = 0;
                player1Count = 0;
                player2Count = 0;
                drawCount = 0;
                button1.Enabled = true;
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
            }
            button3.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
