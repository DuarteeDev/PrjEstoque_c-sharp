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
    public partial class frmEntradaSaida : Form
    {
        public frmEntradaSaida()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcomercialDataSet);

        }

        private void frmEntradaSaida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bDcomercialDataSet.Produto);

        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try //tentar
            {
                //pegar a ID do produto
                int ID = int.Parse (descricaoComboBox.SelectedValue.ToString());
                //pegar a quantidade
                int qtd = int.Parse(quantidadeTextBox.Text);
                //verificar a radio
                if (rbtnEntrada.Checked == true)
                {
                    //chamar o stored ENTRADA
                    produtoTableAdapter.entradaestoquePedro09(qtd, ID);
                    MessageBox.Show("Estoque atualizado com sucesso", "Controle Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtnSaida.Checked == true)
                {
                    produtoTableAdapter.saidaestoquePedro09(qtd, ID);
                    MessageBox.Show("Estoque atualizado com sucesso", "Controle Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha a operação (E/S)", "Controle Estoque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //passar os dois parâmetros (Id e Quantidade)
             }

            catch (Exception) //captura o erro
            {
                MessageBox.Show("Operação não finalizada com sucesso", "Controle Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }
    }
}
