namespace HerreraR_MiPrimerProyectoApi.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public IEnumerable<Cuenta> Cuentas { get; set; } 

    }
}
