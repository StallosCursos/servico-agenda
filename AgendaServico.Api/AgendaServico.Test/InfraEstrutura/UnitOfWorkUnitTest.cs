using AgendaServico.InfraEstrutura;
using AgendaServico.Modelo;
using AgendaServico.Test.Mock;
using Xunit;

namespace AgendaServico.Test.InfraEstrutura
{
    public class UnitOfWorkUnitTest
    {
        [Fact]
        public void Step_01_AdicionarUsuario()
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
                IUnitOfWork unitOfWork = new UnitOfWork(contextFactory.Context);

                unitOfWork.usuarioRepostiory.AdicionarNovoUsuario(usuario);

                unitOfWork.Commit();

                Assert.NotEqual(0, usuario.Id);
            }
        }
    }
}
