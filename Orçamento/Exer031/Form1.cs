using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer031
{
    public partial class Form1 : Form
    {
        private int[] listaParcelas = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            lblProposta.Text = "";
            txtValor.Text = "";
            cbParcela.SelectedIndex = 0;
            txtValor.Focus();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com as formas de pagamento
            for (int x = 1; x <= 6; x++)
            {
                cbParcela.Items.Add(x); ;
            }
            cbParcela.SelectedIndex = 0;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //Cria a instância da Classe. Neste momento o método construtor é executado
            ClsCalcular ObjCalcular = new ClsCalcular();
            //Transfere o "valor" para a classe
            ObjCalcular.Valor = Convert.ToDecimal(txtValor.Text);
            if (cbParcela.SelectedIndex == 0)
            {
                //Executa o método CalcularValor, SEM PARAMETRO, para desconto a vista, que retorna um texto
                lblProposta.Text = ObjCalcular.CalcularValor();
            }
            else
            {
                //Executa o método CalcularValor, COM PARAMETRO, para pagamento parcelado, que retorna um texto
                lblProposta.Text = ObjCalcular.CalcularValor(cbParcela.SelectedIndex + 1);
            }
        }

        private void CbParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaParcelas[0] = 1;
            listaParcelas[1] = 2;
            listaParcelas[2] = 3;
            listaParcelas[3] = 4;
            listaParcelas[4] = 5;
            listaParcelas[5] = 6;
        }
    }
}
        
    

