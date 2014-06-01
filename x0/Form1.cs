using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i;
        int zeroes = 0;
        int crosses = 0;
        int games = 0;
        string[] arr = new string[10];
        string t = "X";
       
        public Form1()
        {
            InitializeComponent();
        }

        public string GameMove(int j)
        {
            string text;
            if (i % 2 == 1)
            {
                t = "X";
                text = "O";
            }
            else { 
                t = "O";
                text = "X";
            }
            text = "Ходит " + text;
            arr[j] = t;
            i += 1;

            label1.Text = text;
            
          
            return t;

        }
        public void GameResult()
        {
            
            if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") | (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") | (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") | (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
            {
                crosses += 1;
                label3.Text = "X : O\n" + crosses.ToString() + " : " + zeroes.ToString();
                MessageBox.Show("Крестики победили!");
                restart();
            }

            if ((arr[1] == "O" & arr[2] == "O" & arr[3] == "O") | (arr[1] == "O" & arr[5] == "O" & arr[9] == "O") | (arr[1] == "O" & arr[4] == "O" & arr[7] == "O") | (arr[2] == "O" & arr[5] == "O" & arr[8] == "O") | (arr[3] == "O" & arr[6] == "O" & arr[9] == "O") | (arr[3] == "O" & arr[5] == "O" & arr[7] == "O") | (arr[4] == "O" & arr[5] == "O" & arr[6] == "O") | (arr[7] == "O" & arr[8] == "O" & arr[9] == "O"))
            {
                zeroes += 1;
                label3.Text = "X : O\n" + crosses.ToString() + " : " + zeroes.ToString();
                MessageBox.Show("Нолики победили!");
                restart();
            }
            if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
            {
                MessageBox.Show(" Ничья!");
                restart();
            }
        }
           
        public void restart()
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
            label1.Text = "";
            for (i = 0; i < 10; i += 1)
            {
                arr[i] = "";
            }
            i = 1;
            games += 1;
            label2.Text = games + " игра";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button1.Text = GameMove(1); GameResult(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button2.Text = GameMove(2); GameResult(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button3.Text = GameMove(3); GameResult(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button4.Text = GameMove(4); GameResult(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button5.Text = GameMove(5); GameResult(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button6.Text = GameMove(6); GameResult(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button7.Text = GameMove(7); GameResult(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button8.Text = GameMove(8); GameResult(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length != 0)
            {
                MessageBox.Show("В этой клетке уже есть крестик или нолик!");
            }
            else { button9.Text = GameMove(9); GameResult(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restart();
            label3.Text = "X : O\n" + crosses.ToString() + " : " + zeroes.ToString();
        }
    }
}
