using AgendaServico.InfraEstrutura.Repositories;
using AgendaServico.InfraEstrutura.Repositories.Interfaces;
using AgendaServico.Modelo;
using AgendaServico.Test.Mock;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgendaServico.Test.Repository
{
    public class UsuarioRepositoryUnitTest
    {
        [Fact]
        public void Step_01_IncluirUsuario()
        {
            Usuario usuario = new Usuario
            {
                Nome = "teste",
                NomeUsuario = "teste teste",
                Email = "teste@teste.com",
                Senha = "123456"
            };

            using (ContextFactory contextFactory = new ContextFactory())
            {
                var shareContext = contextFactory.Context;

                IUsuarioRepository usuarioRepository = new UsuarioRepository(shareContext);
                usuarioRepository.AdicionarNovoUsuario(usuario);

                shareContext.SaveChanges();
            }
        }
    }
}
