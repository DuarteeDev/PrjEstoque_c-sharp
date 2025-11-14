using PrjEstoque.BDcomercialDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadCategoria categoria = new frmCadCategoria(); //Cria uma instancia do form
            categoria.TopLevel = false; //Desativa para nao aparecer sobre outro form
            categoria.Dock = DockStyle.Fill; //Preencher todo o painel
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(categoria); //Adiciona o form dentro do painelCentral
            categoria.Show(); //Exibe o form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//botao INICIO)
            panelCentral.Controls.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar todo o sistema", "Controle de acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); //Encerra todo o projeto
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized; //Minimiza o form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadProduto produto = new frmCadProduto(); //Cria uma instancia do form
            produto.TopLevel = false; //Desativa para nao aparecer sobre outro form
            produto.Dock = DockStyle.Fill; //Preencher todo o painel
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(produto); //Adiciona o form dentro do painelCentral
            produto.Show(); //Exibe o form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEntradaSaida produto = new frmEntradaSaida(); //Cria uma instancia do form
            produto.TopLevel = false; //Desativa para nao aparecer sobre outro form
            produto.Dock = DockStyle.Fill; //Preencher todo o painel
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(produto); //Adiciona o form dentro do painelCentral
            produto.Show(); //Exibe o form
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmConsultarEstoqueMinimo produto = new frmConsultarEstoqueMinimo(); //Cria uma instancia do form
            produto.TopLevel = false; //Desativa para nao aparecer sobre outro form
            produto.Dock = DockStyle.Fill; //Preencher todo o painel
            panelCentral.Controls.Clear(); //Limpa o painel
            panelCentral.Controls.Add(produto); //Adiciona o form dentro do painelCentral
            produto.Show(); //Exibe o form
        }
    }
}
