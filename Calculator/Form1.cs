using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double CurrentNumber { get; set; } = 0;
        private double ResultNumber { get; set; } = 0;
        private bool CheckError { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCurrentNumber()
        {
            if(label2.Text.Length >= 10)
            {
                MessageBox.Show("Error");
                CurrentNumber = 0;
                label2.Text = "0";
            }
            label2.Text = CurrentNumber.ToString();
            label2.Show();
        }

        private void ShowResultNumber()
        {
            label1.Text = ResultNumber.ToString();
            if (label1.Text.Length >= 10)
            {
                label1.Text = "Error!";
                CheckError = true;
            }
            label1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ClientSize = new Size(342, 602);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 1;
            ShowCurrentNumber();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 2;
            ShowCurrentNumber();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 3;
            ShowCurrentNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 4;
            ShowCurrentNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 5;
            ShowCurrentNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 6;
            ShowCurrentNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 7;
            ShowCurrentNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 8;
            ShowCurrentNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10 + 9;
            ShowCurrentNumber();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CurrentNumber = CurrentNumber * 10;
            ShowCurrentNumber();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CurrentNumber = 0;
            ShowCurrentNumber();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CurrentNumber = 0;
            ResultNumber = 0;
            ShowResultNumber();
            ShowCurrentNumber();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ResultNumber += CurrentNumber;
            label1.Text = label1.Text + "+" + CurrentNumber.ToString();
            CurrentNumber = 0;
            label1.Show();
            ShowCurrentNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = ResultNumber.ToString();
            label2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultNumber -= CurrentNumber;
            label1.Text = label1.Text + "-" + CurrentNumber.ToString();
            CurrentNumber = 0;
            label1.Show();  
            ShowCurrentNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultNumber *= CurrentNumber;
            label1.Text = "*" + label1.Text + ")*" + CurrentNumber.ToString();
            CurrentNumber = 0;
            label1.Show();
            ShowCurrentNumber();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (CurrentNumber != 0)
            {
                ResultNumber /= CurrentNumber;
                label1.Text = "(" + label1.Text + ")/" + CurrentNumber.ToString();
                CurrentNumber = 0;
                label1.Show();
                ShowCurrentNumber();
            }
            else
            {
                MessageAndNull();
            }
        }

        public void MessageAndNull()
        {
            MessageBox.Show("Error");
            CurrentNumber = 0;
            ResultNumber = 0;
            label1.Text = "0";
            label2.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string tmp = CurrentNumber.ToString();
            if (tmp.Length > 1)
            {
                tmp = tmp.Substring(0, tmp.Length - 1);
                CurrentNumber = Convert.ToDouble(tmp);
            }
            else
            {
                CurrentNumber = 0;
            }
            ShowCurrentNumber();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                CurrentNumber = CurrentNumber / 10;
            }
            ShowCurrentNumber() ;   
        }
    }
}
