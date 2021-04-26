using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.Modelo
{
    public class Contato: Entidade
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario Usuario { get; set; }
        public List<NumeroContato> NumerContato { get; set; }
    }
}
