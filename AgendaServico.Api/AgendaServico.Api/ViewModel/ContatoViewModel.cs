using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaServico.Api.ViewModel
{
    public class ContatoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<NumeroContatoViewModel> NumeroContato { get; set; }
    }
}
