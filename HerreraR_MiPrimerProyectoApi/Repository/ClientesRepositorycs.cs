using HerreraR_MiPrimerProyectoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerreraR_MiPrimerProyectoApi.Repository
{
    public class ClientesRepositorycs
    {
        private CuentaRepositorycs _cuentasRepository;

        public ClientesRepositorycs()
        {
            _cuentasRepository = new CuentaRepositorycs();
        }

        //Metodo get Listado de clientes
        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente1 = new Cliente
            {
                Id = "1726195520",
                Nombre = "Ricardo Herrera",
                Correo = "riki@gmail.com",
                Cuentas = _cuentasRepository.ObtenerListadoCuentasPorCliente("1726195520")
            };

            Cliente cliente2 = new Cliente
            {
                Id = "1726195521",
                Nombre = "Sofia Vergara",
                Correo = "sofi@gmail.com",
                Cuentas = _cuentasRepository.ObtenerListadoCuentasPorCliente("1726195521")
            };

            clientes.Add(cliente1);
            clientes.Add(cliente2);

            return clientes;
        }

        public Cliente ObtenerInfoClientePorId(String Id)
        {
            var clientes = ObtenerListadoClientes();
            Cliente cliente = clientes.First(item => item.Id == Id);
            return cliente;
        }

        public bool CrearCliene(Cliente cliente)
        {
            return true;
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            return true;
        }

        public bool EliminarCliente(string Id)
        {
            return true;
        }

    }
}
