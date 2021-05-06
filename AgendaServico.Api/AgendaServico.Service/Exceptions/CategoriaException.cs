using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.Service.Exceptions
{
    public class CategoriaException: Exception
    {
        public CategoriaException(string message) : base(message)
        {
        }

        public static CategoriaException CategoriaJaAdicionada => new CategoriaException(Mensagens.CategoriaJaAdicionada);
        public static CategoriaException CategoriaNaoAdicionada => new CategoriaException(Mensagens.CategoriaNaoAdicionada);
    }
}
