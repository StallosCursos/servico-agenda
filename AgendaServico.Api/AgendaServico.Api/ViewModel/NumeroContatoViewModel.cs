using System.ComponentModel.DataAnnotations;

namespace AgendaServico.Api.ViewModel
{
    public class NumeroContatoViewModel
    {
        public int Id { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Ddd { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public int TipoContato { get; set; }
    }
}