using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ModificadorLinha
{
    public partial class frmChaves : Form
    {
        public frmChaves()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var saida = string.Join(Environment.NewLine, txtChaves.Lines.Select(x => txtSaiChave1.Text + x + txtSaiChave2.Text));
            txtResultado.Text = saida;
        }
    }
}
