using System;

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
                return false;
        }
    }
}
