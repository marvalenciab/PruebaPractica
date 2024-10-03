using System.ComponentModel.DataAnnotations;

namespace backendPrueba.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpedicion { get; set; }
        [Required]
        public string CVV { get; set; }
    }
}
