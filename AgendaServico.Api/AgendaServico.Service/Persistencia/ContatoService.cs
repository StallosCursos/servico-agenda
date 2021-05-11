using AgendaServico.Modelo;
using AgendaServico.InfraEstrutura;
using AgendaServico.Service.Exceptions;
using System.Linq;
using AgendaServico.Service.Persistencia.Interfaces;
using System.Collections.Generic;

namespace AgendaServico.Service.Persistencia
{
    public class ContatoService : IContatoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContatoService(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        private Usuario BuscarUsuario(string nomeUsuario)
        {
            var usuarioPersistido = _unitOfWork.usuarioRepostiory.BuscarUsuarioPorNome(nomeUsuario);

            if (usuarioPersistido == null)
                throw UsuarioException.UsuarioNaoExistente;

            return usuarioPersistido;
        }

        public Contato NovoContato(string nomeUsuario, Contato contato)
        {
            Usuario usuarioPersistido = BuscarUsuario(nomeUsuario);

            usuarioPersistido.Contatos.Add(contato);

            _unitOfWork.Commit();

            return contato;
        }

        public Contato AtualizarContato(string nomeUsuario, Contato contato)
        {
            Usuario usuarioPersistido = BuscarUsuario(nomeUsuario);

            var contatoPersistido = usuarioPersistido.Contatos.FirstOrDefault(t => t.Id == contato.Id);

            contatoPersistido.Nome = contato.Nome;
            contatoPersistido.NumerContato = contato.NumerContato;

            _unitOfWork.usuarioRepostiory.AlterarUsuario(usuarioPersistido);
            _unitOfWork.Commit();

            return contato;
        }

        public Contato RemoverContato(string nomeUsuario, Contato contato)
        {
            Usuario usuarioPersistido = BuscarUsuario(nomeUsuario);

            var contatoPersistido = usuarioPersistido.Contatos.FirstOrDefault(t => t.Id == contato.Id);

            usuarioPersistido.Contatos.Remove(contatoPersistido);

            _unitOfWork.usuarioRepostiory.AlterarUsuario(usuarioPersistido);
            _unitOfWork.Commit();

            return contato;
        }

        public List<Contato> BuscarContatos(string nomeUsuario) => 
            BuscarUsuario(nomeUsuario).Contatos;
    }
}
