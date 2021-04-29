using AgendaServico.InfraEstrutura;
using AgendaServico.Modelo;
using AgendaServico.Service.Exceptions;
using AgendaServico.Service.Extensoes;
using System.Linq;

namespace AgendaServico.Service.Acesso
{
    public class AutenticacaoService
    {
        private IUnitOfWork _unitOfWork;

        public AutenticacaoService(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        /*public string Login(Usuario usuario)
        {
            var usuarioPersistido = _unitOfWork.usuarioRepostiory.BuscarUsuarios(t => t.NomeUsuario == usuario.NomeUsuario).FirstOrDefault();

            if (usuarioPersistido == null)
               throw UsuarioException.UsuarioNaoExistente;

            if (usuarioPersistido.Senha != usuario.HashSenha())
               throw UsuarioException.UsuarioNaoExistente;


        }*/
    }
}
