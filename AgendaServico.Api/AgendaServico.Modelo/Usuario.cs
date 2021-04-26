using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.Modelo
{
    public class Usuario: Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public List<Contato> Contatos { get; set; }
    }
}
