using System.Windows.Forms;

namespace ModificadorLinha
{
    public partial class CntLinha : UserControl
    {
        public string Id { get; set; }

        private Cnt ParentItem { get; set; }

        public ModelFiltro Filtro{ get; set; }

        public CntLinha(ModelFiltro filtro, Cnt parentItem)
        {
            InitializeComponent();
            this.Filtro = filtro;


            cmbOperador.Items.Add("And");
            cmbOperador.Items.Add("Or");

            cmbFuncao.Items.Add("Contem");
            cmbFuncao.Items.Add("Nao Contem");

            this.cmbFuncao.SelectedIndex = 0;
            this.cmbOperador.SelectedIndex = 0;

            this.ParentItem = parentItem;
            this.cmbFuncao.SelectedIndex = filtro.Funcao;
            this.cmbOperador.SelectedIndex = filtro.Operador;
            this.txtTexto.Text = filtro.Texto;
            this.Id = filtro.Id;
        }

        private void btnRemover_Click(object sender, System.EventArgs e)
        {
            ParentItem.Remover(this.Id);
        }

        private void cmbOperador_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Filtro.Operador = cmbOperador.SelectedIndex;
        }

        private void cmbFuncao_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Filtro.Funcao = cmbFuncao.SelectedIndex;
        }

        private void txtTexto_TextChanged(object sender, System.EventArgs e)
        {
            this.Filtro.Texto = txtTexto.Text;
        }
    }
}
