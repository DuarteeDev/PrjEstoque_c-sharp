using PrjEstoque;
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
    public partial class frmConsultarEstoqueMinimo : Form
    {
        public frmConsultarEstoqueMinimo()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcomercialDataSet);

        }

        private void frmConsultarEstoqueMinimo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bDcomercialDataSet.Produto);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidadeMinima = int.Parse(textBox1.Text);

                this.produtoTableAdapter.FillByEstoqueMinimo(this.bDcomercialDataSet.Produto, quantidadeMinima);

                produtoDataGridView.DataSource = bDcomercialDataSet.Produto;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um valor numérico válido para a quantidade mínima.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
            }
        }
        private void produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

