using System;
using System.Collections.Generic;

namespace Biblioteca_de_Clases
{
    public class Negocio
    {
        private List<Cliente> clientes;

        public Negocio()
        {
            clientes = new List<Cliente>();
        }

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
    }
}
