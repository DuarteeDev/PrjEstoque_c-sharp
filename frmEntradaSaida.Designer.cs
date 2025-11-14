namespace PrjEstoque
{
    partial class frmEntradaSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.bDcomercialDataSet = new PrjEstoque.BDcomercialDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new PrjEstoque.BDcomercialDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new PrjEstoque.BDcomercialDataSetTableAdapters.TableAdapterManager();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnEntrada = new System.Windows.Forms.RadioButton();
            this.rbtnSaida = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDcomercialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTRADA E SAÍDA DE ESTOQUE";
            // 
            // bDcomercialDataSet
            // 
            this.bDcomercialDataSet.DataSetName = "BDcomercialDataSet";
            this.bDcomercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bDcomercialDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrjEstoque.BDcomercialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(35, 126);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(83, 20);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataSource = this.produtoBindingSource;
            this.descricaoComboBox.DisplayMember = "Descricao";
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(140, 123);
            this.descricaoComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(164, 28);
            this.descricaoComboBox.TabIndex = 3;
            this.descricaoComboBox.ValueMember = "ProdutoId";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(35, 185);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(100, 20);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(140, 182);
            this.quantidadeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(164, 27);
            this.quantidadeTextBox.TabIndex = 5;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Operaçâo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtnEntrada
            // 
            this.rbtnEntrada.AutoSize = true;
            this.rbtnEntrada.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntrada.Location = new System.Drawing.Point(151, 291);
            this.rbtnEntrada.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnEntrada.Name = "rbtnEntrada";
            this.rbtnEntrada.Size = new System.Drawing.Size(89, 24);
            this.rbtnEntrada.TabIndex = 8;
            this.rbtnEntrada.TabStop = true;
            this.rbtnEntrada.Text = "Entrada";
            this.rbtnEntrada.UseVisualStyleBackColor = true;
            // 
            // rbtnSaida
            // 
            this.rbtnSaida.AutoSize = true;
            this.rbtnSaida.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSaida.Location = new System.Drawing.Point(151, 325);
            this.rbtnSaida.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnSaida.Name = "rbtnSaida";
            this.rbtnSaida.Size = new System.Drawing.Size(69, 24);
            this.rbtnSaida.TabIndex = 9;
            this.rbtnSaida.TabStop = true;
            this.rbtnSaida.Text = "Saída";
            this.rbtnSaida.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(151, 371);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(67, 49);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbtnSaida);
            this.Controls.Add(this.rbtnEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmEntradaSaida";
            this.Text = "frmEntradaSaida";
            this.Load += new System.EventHandler(this.frmEntradaSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDcomercialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BDcomercialDataSet bDcomercialDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private BDcomercialDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private BDcomercialDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnEntrada;
        private System.Windows.Forms.RadioButton rbtnSaida;
        private System.Windows.Forms.Button btnOk;
    }
}