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
    public partial class frmCadCategoria : Form
    {
        public static int Codtroca;
        public frmCadCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcomercialDataSet);

        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.bDcomercialDataSet.categoria);

        }

        private void button1_Click(object sender, EventArgs e)
        {//botao NOVO
            //criar um espaço em branco 
            //depois 'deverá salvar'
            categoriaBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {//botao Primeiro
            categoriaBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {//botao anterior
            categoriaBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {//botao proximo
            categoriaBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {//botao ultimo
            categoriaBindingSource.MoveLast();

        }

        private void button2_Click(object sender, EventArgs e)
        {//botao salvar
            try //tentar
            {
                 categoriaBindingSource.EndEdit(); //finaliza edição
                categoriaTableAdapter.Update(bDcomercialDataSet.categoria);
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
            categoriaBindingSource.CancelEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {//botao remover
            try //tratar o erro
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Controle de Estoque",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //remover
                    categoriaBindingSource.RemoveCurrent();
                    //salvar
                    categoriaTableAdapter.Update(bDcomercialDataSet.categoria);
                }

                }
            catch (Exception)
            {

                MessageBox.Show("Registro não pode ser removido", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.categoriaTableAdapter.Fill(this.bDcomercialDataSet.categoria); //recarregar os dados

                return; 
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //executar o filtro(cláusula WHERE do SQL)
            //usamos a propriedade FILTER
            //tem que saber o nome exato do campo no BD
            categoriaBindingSource.Filter = $"nome like '{toolStripTextBox1.Text}%'";
        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.RemoveFilter();
            toolStripTextBox1.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //declarar uma variável publica no inicio(topo) desse form
            Codtroca = 0;
            frmConsulCategoria consulta = new frmConsulCategoria();
            consulta.ShowDialog(); //chama o form e aguarda ele ser fechado
            if (Codtroca!=0) //se o código NÃO for zero
            {
                //posiciona o registro na posição do Id consultado
                categoriaBindingSource.Position =
                    categoriaBindingSource.Find("categoriaId", Codtroca);
            }
        }
    }
}
