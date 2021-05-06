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
    public class ContaServiceUnitTest
    {
        private readonly IUnitOfWork _unitWork;
        private readonly IContasService _contasService;

        public ContaServiceUnitTest()
        {
            var context = new ContextFactory().Context;
            _unitWork = new UnitOfWork(context);

            _contasService = new ContasService(_unitWork);
        }

        [Fact]
        public void Step_01_NovaConta()
        {
            Usuario usuario = new Usuario
            {
                Nome = "testservice",
                NomeUsuario = "testservice",
                Senha = "123456",
                Email = "testservice@teste.com"
            };

            _contasService.NovaConta(usuario);

            Assert.NotEqual(0, usuario.Id);
        }
    }
}
