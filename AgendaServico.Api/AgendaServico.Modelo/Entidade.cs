using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.Modelo
{
    public class Entidade
    {
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Entidade Objeto)
                return Objeto.Id == this.Id;
            else
                throw new InvalidOperationException("Entidades comparadas não são de mesmo tipo");
        }
    }
}
