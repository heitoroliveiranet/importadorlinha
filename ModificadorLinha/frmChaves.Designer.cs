
namespace ModificadorLinha
{
    partial class frmChaves
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
            this.txtChaves = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtSaiChave2 = new System.Windows.Forms.TextBox();
            this.txtSaiChave1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChaves
            // 
            this.txtChaves.Location = new System.Drawing.Point(53, 98);
            this.txtChaves.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtChaves.Multiline = true;
            this.txtChaves.Name = "txtChaves";
            this.txtChaves.Size = new System.Drawing.Size(930, 749);
            this.txtChaves.TabIndex = 4;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(1910, 861);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(200, 74);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Executar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nomes das chaves:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(1040, 98);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(1070, 749);
            this.txtResultado.TabIndex = 7;
            // 
            // txtSaiChave2
            // 
            this.txtSaiChave2.Location = new System.Drawing.Point(418, 880);
            this.txtSaiChave2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSaiChave2.Name = "txtSaiChave2";
            this.txtSaiChave2.Size = new System.Drawing.Size(158, 38);
            this.txtSaiChave2.TabIndex = 33;
            // 
            // txtSaiChave1
            // 
            this.txtSaiChave1.Location = new System.Drawing.Point(219, 880);
            this.txtSaiChave1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSaiChave1.Name = "txtSaiChave1";
            this.txtSaiChave1.Size = new System.Drawing.Size(158, 38);
            this.txtSaiChave1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 883);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Saida entre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1055, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 80);
            this.label2.TabIndex = 34;
            this.label2.Text = "Resultado";
            // 
            // frmChaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2143, 970);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaiChave2);
            this.Controls.Add(this.txtSaiChave1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtChaves);
            this.Name = "frmChaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChaves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChaves;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtSaiChave2;
        private System.Windows.Forms.TextBox txtSaiChave1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}