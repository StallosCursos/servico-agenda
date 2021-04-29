using System;

namespace AgendaServico.Service.Exceptions
{
    public class UsuarioException : Exception
    {
        public UsuarioException(string message) : base(message)
        {
        }

        public static UsuarioException UsuarioJaFoiCadastrado => new UsuarioException(Mensagens.UsuarioExistente);
        public static UsuarioException SenhaNaoFornecida => new UsuarioException(Mensagens.SenhaNaoFornecida);
        public static UsuarioException UsuarioNaoExistente => new UsuarioException(Mensagens.UsuarioNaoExiste);
        public static UsuarioException SenhasNaoConferem => new UsuarioException(Mensagens.SenhasNaoConferem); 
    }
}
