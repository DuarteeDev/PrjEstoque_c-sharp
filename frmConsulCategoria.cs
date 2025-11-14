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
    public partial class frmConsulCategoria : Form
    {
        public frmConsulCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcomercialDataSet);

        }

        private void frmConsulCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcomercialDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.bDcomercialDataSet.categoria);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose(); //destrói o form
        }

        private void categoriaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try //tentar pegar o valor da célula categoriaID (célula 0)
            {
                frmCadCategoria.Codtroca = int.Parse(categoriaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            { //caso dê erro, deixa a variável como zero

                frmCadCategoria.Codtroca = 0;
            }
            this.Dispose(); //destrói o form
        }
    }
}
