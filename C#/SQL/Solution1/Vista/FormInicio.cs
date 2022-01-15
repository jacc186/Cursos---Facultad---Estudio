using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Clases;

namespace Vista
{
    public partial class formClientes : Form
    {
        Negocio negocio;
        
        public formClientes()
        {
            InitializeComponent();
            negocio = new Negocio();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            this.dataGridViewClientes.DataSource = AccesoDatos.leerClientes(); ;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            FormDetalle formDetalle = new FormDetalle(negocio, dataGridViewClientes);
            formDetalle.ShowDialog();
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = dataGridViewClientes.CurrentRow.DataBoundItem as Cliente;
            FormDetalle formDetalle = new FormDetalle(negocio, dataGridViewClientes, cliente);
            formDetalle.ShowDialog();           
        }
    }
}
