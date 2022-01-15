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
    public partial class FormDetalle : Form
    {
        Negocio negocio;
        DataGridView dataGrid;
        Cliente cliente;
        public FormDetalle()
        {
            InitializeComponent();
        }
        public FormDetalle(Negocio negocio, DataGridView dataGrid) : this()
        {
            this.negocio = negocio;
            this.dataGrid = dataGrid;
        }
        public FormDetalle(Negocio negocio, DataGridView dataGrid, Cliente cliente) : this(negocio, dataGrid)
        {
            this.cliente = cliente;
            AbrirTextos();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(cliente is null)
            {
            cliente = new Cliente(
            textBoxNombre.Text, textBoxApellido.Text,
            textBoxDireccion.Text, int.Parse(textBoxTelefono.Text));
            }
            else
            {
                cliente.Nombre = textBoxNombre.Text;
                cliente.Apellido = textBoxApellido.Text;
                cliente.Direccion = textBoxDireccion.Text;
                cliente.Telefono = long.Parse(textBoxTelefono.Text);
            }
            AccesoDatos.ModificarCliente(cliente);
            dataGrid.DataSource = null;
            dataGrid.DataSource = AccesoDatos.leerClientes();
            DialogResult = DialogResult.OK;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void AbrirTextos()
        {
            textBoxNombre.Text = cliente.Nombre;
            textBoxApellido.Text = cliente.Apellido;
            textBoxDireccion.Text = cliente.Apellido;
            textBoxTelefono.Text = cliente.Telefono.ToString();
        }
    }
}
