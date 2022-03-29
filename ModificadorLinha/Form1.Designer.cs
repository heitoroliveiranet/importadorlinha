namespace ModificadorLinha
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtExtensoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtNovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optIncluirArquivos = new System.Windows.Forms.CheckBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.chkGerarOld = new System.Windows.Forms.CheckBox();
            this.optDiretorios = new System.Windows.Forms.CheckBox();
            this.cnt1 = new ModificadorLinha.Cnt();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(1380, 758);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(200, 74);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(205, 43);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(676, 38);
            this.txtCaminho.TabIndex = 3;
            this.txtCaminho.Text = "C:\\";
            // 
            // txtExtensoes
            // 
            this.txtExtensoes.Location = new System.Drawing.Point(205, 105);
            this.txtExtensoes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtExtensoes.Name = "txtExtensoes";
            this.txtExtensoes.Size = new System.Drawing.Size(676, 38);
            this.txtExtensoes.TabIndex = 5;
            this.txtExtensoes.Text = "*.config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extensoes:";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 31;
            this.lst.Location = new System.Drawing.Point(40, 175);
            this.lst.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(1540, 500);
            this.lst.TabIndex = 6;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            this.lst.DoubleClick += new System.EventHandler(this.lst_DoubleClick);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(1380, 110);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(200, 55);
            this.btnLocalizar.TabIndex = 9;
            this.btnLocalizar.Text = "Localizar Arquivos";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtNovo
            // 
            this.txtNovo.Location = new System.Drawing.Point(824, 696);
            this.txtNovo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(756, 38);
            this.txtNovo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 702);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Novo Texto:";
            // 
            // optIncluirArquivos
            // 
            this.optIncluirArquivos.AutoSize = true;
            this.optIncluirArquivos.Location = new System.Drawing.Point(824, 758);
            this.optIncluirArquivos.Name = "optIncluirArquivos";
            this.optIncluirArquivos.Size = new System.Drawing.Size(532, 36);
            this.optIncluirArquivos.TabIndex = 12;
            this.optIncluirArquivos.Text = "Incluir alteracao em nome de arquivos";
            this.optIncluirArquivos.UseVisualStyleBackColor = true;
            this.optIncluirArquivos.CheckedChanged += new System.EventHandler(this.optIncluirArquivos_CheckedChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(908, 107);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(200, 55);
            this.btnFiltro.TabIndex = 14;
            this.btnFiltro.Text = "Novo Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Texto Pesquisa:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(907, 58);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(676, 38);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.Text = "teste";
            // 
            // chkGerarOld
            // 
            this.chkGerarOld.AutoSize = true;
            this.chkGerarOld.Checked = true;
            this.chkGerarOld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGerarOld.Location = new System.Drawing.Point(300, 702);
            this.chkGerarOld.Name = "chkGerarOld";
            this.chkGerarOld.Size = new System.Drawing.Size(252, 36);
            this.chkGerarOld.TabIndex = 15;
            this.chkGerarOld.Text = "Backup Arquivo";
            this.chkGerarOld.UseVisualStyleBackColor = true;
            // 
            // optDiretorios
            // 
            this.optDiretorios.AutoSize = true;
            this.optDiretorios.Location = new System.Drawing.Point(824, 799);
            this.optDiretorios.Name = "optDiretorios";
            this.optDiretorios.Size = new System.Drawing.Size(542, 36);
            this.optDiretorios.TabIndex = 16;
            this.optDiretorios.Text = "Incluir alteracao em nome de diretorios";
            this.optDiretorios.UseVisualStyleBackColor = true;
            // 
            // cnt1
            // 
            this.cnt1.Location = new System.Drawing.Point(1607, 58);
            this.cnt1.Name = "cnt1";
            this.cnt1.Size = new System.Drawing.Size(1407, 601);
            this.cnt1.TabIndex = 13;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3026, 848);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.optDiretorios);
            this.Controls.Add(this.chkGerarOld);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.cnt1);
            this.Controls.Add(this.optIncluirArquivos);
            this.Controls.Add(this.txtNovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.txtExtensoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificador de Valores em Arquivo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtExtensoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox optIncluirArquivos;
        private Cnt cnt1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.CheckBox chkGerarOld;
        private System.Windows.Forms.CheckBox optDiretorios;
    }
}

