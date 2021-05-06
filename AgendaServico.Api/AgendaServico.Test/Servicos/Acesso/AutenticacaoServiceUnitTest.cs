using AgendaServico.InfraEstrutura;
using AgendaServico.Modelo;
using AgendaServico.Service.Acesso;
using AgendaServico.Service.Acesso.Interfaces;
using AgendaServico.Test.Mock;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgendaServico.Test.Servicos.Acesso
{
    public class AutenticacaoServiceUnitTest
    {
        private readonly IUnitOfWork _unitWork;
        private readonly IAutenticacaoService _autenticacaoService;
        private readonly IContasService _contasService;

        public AutenticacaoServiceUnitTest()
        {
        }

        [Fact]
        public void Step_01_Login()
        {
            Usuario usuario = new Usuario
            {
                Nome = "testservice",
                NomeUsuario = "testservice",
                Senha = "123456",
                Email = "testservice@teste.com"
            };

            _contasService.NovaConta(usuario);

            Usuario usuarioLogin = new Usuario
            {
                NomeUsuario = "testservice",
                Senha = "123456"
            };

            var token = _autenticacaoService.Login(usuarioLogin);

            Assert.True(string.IsNullOrEmpty(token));
        }
    }
}
