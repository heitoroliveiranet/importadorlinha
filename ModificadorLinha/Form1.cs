using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            if (dirs.Length > 0)
            {
                Directory.Move(dirs[0], dirs[0].Replace(txtPesquisar.Text, txtNovo.Text));
                AlterarDiretorios();
            }
        }
        public string GetTexto(string texto, string busca1, string busca2, string saida1, string saida2, bool somenteChaves = false)
        {
            while (texto.Contains(busca1) && texto.Contains(busca2))
            {
                var p1 = texto.IndexOf(busca1) + busca1.Length;
                var p2 = texto.IndexOf(busca2, p1 + 1);
                var interno = texto.Substring(p1, p2 - p1);

                if (somenteChaves)
                {
                    texto = saida1 + interno + saida2;
                }
                else
                {
                    texto = texto.Substring(0, p1 - busca1.Length) +
                        saida1 +
                        interno + saida2 +
                        texto.Substring(p2 + busca2.Length);
                }
            }

            return texto;
        }
        public string[] GetTextos(string texto, string busca1, string busca2, string saida1, string saida2, bool somenteChaves = false)
        {
            var lista = new List<string>();
            var novoTexto = "";
            var p1 = 0;
            var p2 = -1;
            while (texto.Contains(busca1) && texto.Contains(busca2))
            {
                p1 = texto.IndexOf(busca1, p2 + 1);
                if (p1 == -1) break;
                p1 += busca1.Length;
                p2 = texto.IndexOf(busca2, p1 + 1);
                if (p2 == -1) break;

                var interno = texto.Substring(p1, p2 - p1);

                if (somenteChaves)
                {
                    novoTexto = saida1 + interno + saida2;
                }
                else
                {
                    novoTexto = texto.Substring(0, p1 - busca1.Length) +
                        saida1 +
                        interno + saida2 +
                        texto.Substring(p2 + busca2.Length);
                }
                if (novoTexto.Trim().Length > 0)
                    lista.Add(novoTexto);

                novoTexto = "";
            }

            return lista.ToArray();
        }
        public void Alterar()
        {
            var arquivoKeysSaida = "";
            foreach (var item in lst.Items)
            {
                var caminhoArquivo = item.ToString();
                var flInfo = new FileInfo(caminhoArquivo);
                var texto = "";

                if (chkEntre.Checked)
                {
                    var lns = File.ReadAllLines(caminhoArquivo);
                    foreach (var ln in lns)
                    {
                        var nln = GetTexto(ln, txtBusca1.Text, txtBusca2.Text, txtRep1.Text, txtRep2.Text);
                        texto += nln + Environment.NewLine;
                    }
                }
                else if (chkChaves.Checked)
                {
                    var lns = File.ReadAllText(caminhoArquivo);
                    foreach (var ln in GetTextos(lns, txtChave1.Text, txtChave2.Text, txtSaiChave1.Text, txtSaiChave2.Text, true))
                    {
                        if (txtSplit.Text.Length > 0)
                        {
                            var splits = ln.Split(txtSplit.Text.ToCharArray()[0]);
                            foreach (var sp in splits)
                            {
                                var ls = arquivoKeysSaida.Split(Environment.NewLine.ToCharArray()).ToList();
                                if (chkAgruparChaves.Checked && !ls.Contains(sp) || !chkAgruparChaves.Checked)
                                    arquivoKeysSaida += sp + Environment.NewLine;
                            }
                        }
                        else
                        {
                            if (chkAgruparChaves.Checked && !arquivoKeysSaida.Contains(ln) || !chkAgruparChaves.Checked)
                                arquivoKeysSaida += ln + Environment.NewLine;
                        }
                    }
                    continue;
                }
                else
                {
                    texto = File.ReadAllText(caminhoArquivo).Replace(txtPesquisar.Text, txtNovo.Text);
                }

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

            if (chkChaves.Checked) File.WriteAllText(@"C:\lixo\keys.txt", arquivoKeysSaida);

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
                ArquivoContem(item);
            }

            foreach (var dir in Directory.GetDirectories(caminho))
            {
                Localizar(dir);
            }
        }
        public bool ArquivoContem(string caminhoArquivo)
        {
            var txt = File.ReadAllText(caminhoArquivo);
            var c = (txt.Contains(txtPesquisar.Text) && cnt1.Validar(txt) || optIncluirArquivos.Checked && caminhoArquivo.ToUpper().Contains(txtPesquisar.Text.ToUpper()));
            if (c) lst.Items.Add(caminhoArquivo);
            return c;
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

        private void chkEntre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarChaves_Click(object sender, EventArgs e)
        {
            var frm = new frmChaves();
            frm.ShowDialog();
        }
    }
}
