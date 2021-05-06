using AgendaServico.InfraEstrutura;
using AgendaServico.Modelo;
using AgendaServico.Service.Acesso.Interfaces;
using AgendaServico.Service.Exceptions;
using AgendaServico.Service.Extensoes;
using System.Linq;

namespace AgendaServico.Service.Acesso
{
    public class ContasService : IContasService
    {
        private readonly IUnitOfWork _unitOfwork;

        public ContasService(IUnitOfWork unitOfWork) =>
            _unitOfwork = unitOfWork;

        public Usuario NovaConta(Usuario usuario)
        {
            var usuarioExistente = _unitOfwork.usuarioRepostiory.BuscarUsuarios(t => t.NomeUsuario == usuario.NomeUsuario).FirstOrDefault();

            if (usuarioExistente != null)
                throw UsuarioException.UsuarioJaFoiCadastrado;

            usuario.Senha = usuario.HashSenha();

            _unitOfwork.usuarioRepostiory.AdicionarNovoUsuario(usuario);
            _unitOfwork.Commit();

            usuario.Senha = string.Empty;

            return usuario;
        }
    }
}
