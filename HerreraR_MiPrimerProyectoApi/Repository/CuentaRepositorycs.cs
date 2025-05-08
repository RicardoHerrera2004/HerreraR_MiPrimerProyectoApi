using HerreraR_MiPrimerProyectoApi.Models;
using static HerreraR_MiPrimerProyectoApi.Models.Cuenta;

namespace HerreraR_MiPrimerProyectoApi.Repository
{
    public class CuentaRepositorycs
    {
        public IEnumerable<Cuenta> ObtenerListadoCuentasPorCliente(string Id) 
        { 
            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta cuenta1 = new Cuenta
            {
                NumeroCuenta = 123456,
                TipoDeCuenta = TipoCuenta.Ahorro,
                Saldo = 1000
            };

            Cuenta cuenta2 = new Cuenta
            {
                NumeroCuenta = 456789,
                TipoDeCuenta = TipoCuenta.Corriente,
                Saldo = 1500
            };

            cuentas.Add(cuenta1);
            cuentas.Add(cuenta2);

            return cuentas;
        }
    }
}
