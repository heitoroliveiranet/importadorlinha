using System;
using System.Windows.Forms;

namespace TextReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nova = new string[texto.Lines.Length];
            for (int i = 0; i < texto.Lines.Length;i++)
            {
                var txt = Funcoes.RecuperarInterno(texto.Lines[i], txt1.Text, txt2.Text);
                var mask = txtEsq.Text + txt + txtDir.Text;

                while(mask.Contains(prmdolar.Text))
                    mask = mask.Replace(prmdolar.Text, txt);

                nova[i] = (txtEsq.Text + txt + txtDir.Text).Replace(prmdolar.Text, txt);
            }

            texto.Lines = nova;
        }
    }
    public class Funcoes {
        public static string RecuperarInterno(string texto, string valorInicio, string valorFim) {
            var p1 = texto.ToUpper().IndexOf(valorInicio.ToUpper());
            if (p1 > -1) { 
                var p2 = texto.ToUpper().IndexOf(valorFim.ToUpper(),p1+1);
                if (p2 > -1) { 
                    var newText = texto.Substring(p1 + valorInicio.Length, p2 - p1 - valorInicio.Length);
                    return newText;
                }
            }
            return "";
        }
    }
}

