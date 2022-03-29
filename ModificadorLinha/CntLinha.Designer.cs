
namespace ModificadorLinha
{
    partial class CntLinha
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(14, 17);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(374, 39);
            this.cmbOperador.TabIndex = 0;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Location = new System.Drawing.Point(394, 17);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(374, 39);
            this.cmbFuncao.TabIndex = 1;
            this.cmbFuncao.SelectedIndexChanged += new System.EventHandler(this.cmbFuncao_SelectedIndexChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(774, 18);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(344, 38);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.TabStop = false;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(1144, 12);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 56);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "X";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // CntLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.cmbFuncao);
            this.Controls.Add(this.cmbOperador);
            this.Name = "CntLinha";
            this.Size = new System.Drawing.Size(1248, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnRemover;
    }
}
