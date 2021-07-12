using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeJeff = 15;
            int idadeMaria = 25;

            var mediaIdade = (idadeJoao + idadeJeff + idadeMaria) / (3);

            MessageBox.Show(mediaIdade.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado	="+piQuebrado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 2, b = 12, c = -14;

            //delta value
            double delta = (b * b) - (4 * a * c);
            //square root = raiz quadrada
            double squareRoot = Math.Sqrt(delta);
            double valuex1 = -(b) + (squareRoot) / (2 * a); 
            double valuex2 = -(b) - (squareRoot) / (2 * a);

            //values with jump line
            MessageBox.Show($" a = {a} {System.Environment.NewLine} b = {b} {System.Environment.NewLine} c={c} {System.Environment.NewLine} delta = {delta}");
            MessageBox.Show($" valuex1 = {valuex1} {System.Environment.NewLine} valuex2 = {valuex2}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double money = 100.0;
            double withdrawal = 10.0;
            double tax;

            if(money <= 0.0)
            {
                tax = 0;
                MessageBox.Show("You haven't value!");
            }
            if (money < 1000 && money > 0.0)
            {
                tax = 0.01 * money;
            }
            if (money <= 5000 && money > 0.0)
            {
                tax = 0.05 * money;
            }
            if (money >= 5001 && money > 0.0)
            {
                tax = 0.10 * money;
            }

            //only can withdrawal(saque) in this situation
            if (money >= withdrawal)
            {
                //final value withdrawal
                double moneyf = money - withdrawal;
                //wgithdrawal = saque
                MessageBox.Show($"Successful withdrawal {withdrawal}, current value {moneyf}");//{tax}
            }
            else
            {
                MessageBox.Show($"your value withdrawal, current value {money}");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
