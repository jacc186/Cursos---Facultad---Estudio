using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecciones1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> cuentaPalabras;

        public Form1()
        {
            InitializeComponent();
            cuentaPalabras = new Dictionary<string, int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextoPlano = richTextBox1.Text;
            string[] separador = TextoPlano.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in separador)
            {
                if (cuentaPalabras.ContainsKey(palabra))
                {
                    cuentaPalabras[palabra]++;
                }
                else
                {
                    cuentaPalabras.Add(palabra, 1);
                }
            }
            cuentaPalabras = cuentaPalabras.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            StringBuilder stringBuilder = new StringBuilder();
            int i=0;
            foreach(KeyValuePair<string, int> valores in cuentaPalabras)
            { if(i<3)
                stringBuilder.AppendFormat("Palabra: {0}, Repeticiones: {1}{2}", valores.Key,valores.Value,Environment.NewLine);
              i++;
            }
            MessageBox.Show(stringBuilder.ToString());
        }

    }
}
