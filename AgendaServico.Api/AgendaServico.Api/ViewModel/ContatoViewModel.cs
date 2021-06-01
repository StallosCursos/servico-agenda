using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaServico.Api.ViewModel
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<NumeroContatoViewModel> NumeroContato { get; set; }
    }
}
