using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_milgrau
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void botao0_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "0";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "2";

        }

        private void botao3_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "3"; ;

        }

        private void botao4_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "4";

        }

        private void botao5_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "5";

        }

        private void botao6_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "6";

        }

        private void botao7_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "7";

        }

        private void botao8_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "9";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tela.Text = "";
        }


        private void button14_Click(object sender, EventArgs e)
        {
            
            if (tela.Text != "")
            {
                
                if (operacao != 0)
                {
                    operacao = 1; 
                    valor1 = Convert.ToDouble(tela.Text); 
                    tela.Text = "";
                }
                else
                {
                    
                    operacao = 1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //igual
            valor2 = Convert.ToDouble(tela.Text);

            if (operacao == 4 && valor2 == 0) 
            {
                tela.Text = "Erro: divisão por zero";
                return;
            }

            switch (operacao)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            tela.Text = resultado.ToString();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            
            if (tela.Text != "")
            {
               
                if (operacao != 0)
                {
                    operacao = 2; 
                }
                else
                {
                    operacao = 2; 
                    valor1 = Convert.ToDouble(tela.Text);
                    tela.Text = "";
                }
            }
        }


        private void vezes_Click(object sender, EventArgs e)
        {
            
            if (tela.Text != "")
            {

                if (operacao != 0)
                {
                    operacao = 3; 
                }
                else
                {
                    operacao = 3; 
                    valor1 = Convert.ToDouble(tela.Text);
                    tela.Text = "";
                }
            }
        }

        private void divisão_Click(object sender, EventArgs e)
        {
            if (tela.Text != "")
            {
                if (operacao != 0)
                {
                    operacao = 4;
                }
                else
                {
                    operacao = 4;
                    valor1 = Convert.ToDouble(tela.Text);
                    tela.Text = "";
                }
            }
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            
            tela.Text = tela.Text + ",";
        }

        
    }
    }
    
    

