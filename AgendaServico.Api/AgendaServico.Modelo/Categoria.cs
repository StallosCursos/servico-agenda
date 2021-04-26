using System.Collections.Generic;

namespace AgendaServico.Modelo
{
    public class Categoria: Entidade
    {
        public string Nome { get; set; }

        public List<NumeroContato> NumeroContatos { get; set; }
    }
}