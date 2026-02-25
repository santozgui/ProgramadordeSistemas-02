using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAtividade
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        bool novoNumero = false; // controla se deve começar um novo número

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numero_Um_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "1";
            this.textBox1.Text = " " + input;
        }
        

        private void numero_Sete_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "7";
            this.textBox1.Text = " " + input;
        
        }

        private void numero_Tres_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "3";
            this.textBox1.Text = " " + input;
        }

        private void numero_Dois_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "2";
            this.textBox1.Text = " " + input;
        }

        private void numero_Seis_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "6";
            this.textBox1.Text = " " + input;
        }

        private void numero_Nove_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "9";
            this.textBox1.Text = " " + input;
        }

        private void numero_Quatro_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "4";
            this.textBox1.Text = " " + input;
        }

        private void numero_Cinco_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "5";
            this.textBox1.Text = " " + input;
        }

        private void numero_Oito_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "8";
            this.textBox1.Text = " " + input;
        }

        private void numero_Zero_Click(object sender, EventArgs e)
        {
            if (novoNumero)
            {
                input = string.Empty; // limpa o input para começar número novo
                novoNumero = false;
            }

            input += "0";
            this.textBox1.Text = " " + input;
        }

        private void btn_Ponto_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                input += ".";
                textBox1.Text = " " + input;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        } 

        private void simb_Soma_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            textBox1.Text = operand1 + " +"; // mostra o número e o sinal
            novoNumero = true;

        }

        private void simb_Multiplicação_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            textBox1.Text = operand1 + " *";
            novoNumero = true;
        }

        private void simb_Divisão_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            textBox1.Text = operand1 + " /";
            novoNumero = true;
        }

        private void simb_Subtrair_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            textBox1.Text = operand1 + " -";
            novoNumero = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
                result = num1 + num2;
            else if (operation == '-')
                result = num1 - num2;
            else if (operation == '*')
                result = num1 * num2;
            else if (operation == '/')
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    textBox1.Text = "DIV/Zero!";
                    input = string.Empty;
                    operand1 = string.Empty;
                    return;
                }
            }

            textBox1.Text = result.ToString();
            input = result.ToString(); // permite continuar operando com o resultado
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
