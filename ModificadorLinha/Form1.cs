using System;
using System.IO;
using System.Windows.Forms;

namespace ModificadorLinha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar os textos informados?", "Atencao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Alterar();

                if (optDiretorios.Checked)
                    AlterarDiretorios();
            }
        }
        public void AlterarDiretorios()
        {
            var dirs = Directory.GetDirectories(txtCaminho.Text, "*" + txtPesquisar.Text + "*", SearchOption.AllDirectories);

            if (dirs.Length > 0) {
                Directory.Move(dirs[0], dirs[0].Replace(txtPesquisar.Text, txtNovo.Text));
                AlterarDiretorios();
            }             
        }
        public void Alterar()
        {
            foreach (var item in lst.Items)
            {
                var caminhoArquivo = item.ToString();
                var flInfo = new FileInfo(caminhoArquivo);
                var texto = File.ReadAllText(caminhoArquivo).Replace(txtPesquisar.Text, txtNovo.Text);

                if (!flInfo.IsReadOnly)
                {
                    if (chkGerarOld.Checked)
                    {
                        try
                        {
                            File.Move(caminhoArquivo, caminhoArquivo + "_old");
                        }
                        catch (Exception)
                        {

                            File.Move(caminhoArquivo, caminhoArquivo + "_old_" + DateTime.Today.ToString("hhMMss") + "_" + new Random().Next(300, 3000));
                        }
                    }
                    else
                    {
                        try
                        {
                            File.Delete(caminhoArquivo);
                        }
                        catch (Exception)
                        {
                        }
                    }

                    if (optIncluirArquivos.Checked && caminhoArquivo.ToUpper().Contains(txtPesquisar.Text.ToUpper()))
                    {
                        caminhoArquivo = Path.Combine(flInfo.DirectoryName, flInfo.Name.Replace(txtPesquisar.Text, txtNovo.Text));
                    }

                    File.WriteAllText(caminhoArquivo, texto);
                }
            }

            MessageBox.Show("Finalizado com sucesso!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();

            try
            {
                btnLocalizar.Text = "Aguarde...";
                btnLocalizar.Enabled = false;
                Localizar(txtCaminho.Text);
            }
            catch (Exception)
            {
            }
            finally
            {
                btnAplicar.Enabled = (lst.Items.Count > 0);
                btnLocalizar.Enabled = true;
                btnLocalizar.Text = "Localizar";
            }
        }
        public void Localizar(string caminho)
        {
            var arqs = Directory.GetFiles(caminho, txtExtensoes.Text);
            foreach (var item in arqs)
            {
                var txt = File.ReadAllText(item);
                if (txt.Contains(txtPesquisar.Text) && cnt1.Validar(txt) || optIncluirArquivos.Checked && item.ToUpper().Contains(txtPesquisar.Text.ToUpper()))
                    lst.Items.Add(item);
            }

            foreach (var dir in Directory.GetDirectories(caminho))
            {
                Localizar(dir);
            }
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lst.SelectedItem.ToString());
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.cnt1.Add(new ModelFiltro());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.cnt1.Add(new ModelFiltro());
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void optIncluirArquivos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
