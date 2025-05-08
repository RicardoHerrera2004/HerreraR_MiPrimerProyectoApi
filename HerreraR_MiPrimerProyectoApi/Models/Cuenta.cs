namespace HerreraR_MiPrimerProyectoApi.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }                                                            
        public TipoCuenta TipoDeCuenta { get; set; }
        public double Saldo { get; set; }                                                       
        public enum TipoCuenta
        {
            Ahorro,
            Corriente
        }
    }
}
