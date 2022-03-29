using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModificadorLinha
{
    public partial class Cnt : UserControl
    {
        public IList<ModelFiltro> Filtros = new List<ModelFiltro>();
        public Cnt()
        {
            InitializeComponent();
        }

        public void Add(ModelFiltro filtro) 
        {
            filtro.Id = Guid.NewGuid().ToString();
            var linha = new CntLinha(filtro,this);
            this.Controls.Add(linha);
            Filtros.Add(filtro);
            Arrange();
        }

        private void Cnt_Load(object sender, EventArgs e)
        {

        }

        public bool Validar(string text) 
        {
            var valida = true;
            foreach (var item in Filtros)
            {
                if (item.Operador == 0) {//And
                    if (item.Funcao == 0) // contem
                        valida = text.Contains(item.Texto);

                    if (item.Funcao == 1) // Nao contem
                        valida = !text.Contains(item.Texto);
                }

                if (item.Operador == 1) //OR
                {
                    if (item.Funcao == 0) // contem
                        valida = valida || text.Contains(item.Texto);

                    if (item.Funcao == 1) // Nao contem
                        valida = valida || !text.Contains(item.Texto);
                }
            }

            return valida;
        }
        public void Remover(string id)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType().Name is "CntLinha")
                {
                    var v = ((CntLinha)item);
                    if (v.Id == id)
                    {
                        this.Controls.Remove(item);
                        Arrange();
                        return;
                    }
                }

            }
        }
        private void Arrange() {
            var oldpos = 0;
            foreach (var item in Controls)
            {
                if (item.GetType().Name is "CntLinha")
                {
                    var v = ((CntLinha)item);
                    v.Top = oldpos;
                    oldpos += v.Height;
                }
            }
        }
    }
}
