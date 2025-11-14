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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.bDcomercialDataSet.categoria);
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bDcomercialDataSet.Produto);

        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcomercialDataSet);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            produtoBindingSource.AddNew();
            data_CadastroLabel1.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {//botao salvar
            try //tentar
            {
                produtoBindingSource.EndEdit(); //finaliza edição
                produtoTableAdapter.Update(bDcomercialDataSet.Produto);
                MessageBox.Show("Registro salvo");
            }
            catch (Exception) //captura
            {

                MessageBox.Show("Verifique os dados informados");
                return;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//botao cancelar
            produtoBindingSource.CancelEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {//botao remover
            try //tratar o erro
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Controle de Estoque",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //remover
                    produtoBindingSource.RemoveCurrent();
                    //salvar
                    produtoTableAdapter.Update(bDcomercialDataSet.Produto);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Registro não pode ser removido", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.produtoTableAdapter.Fill(this.bDcomercialDataSet.Produto); //recarregar os dados

                return;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {//botao Primeiro
            produtoBindingSource.MoveFirst();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {//botao anterior
            produtoBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {//botao proximo
            produtoBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {//botao ultimo
            produtoBindingSource.MoveLast();
        }
    }
}
