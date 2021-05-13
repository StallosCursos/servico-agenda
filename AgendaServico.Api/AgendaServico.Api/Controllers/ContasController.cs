using Microsoft.AspNetCore.Mvc;
using AgendaServico.Modelo;
using AgendaServico.Service.Acesso.Interfaces;
using AgendaServico.Api.ViewModel;

namespace AgendaServico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContasService _contasService;

        public ContasController(IContasService contasService)
        {
            _contasService = contasService;
        }

        [HttpPost]
        public UsuarioViewModel NovaConta(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = new Usuario
            {
                Nome = usuarioViewModel.Nome,
                Senha = usuarioViewModel.Senha,
                Email = usuarioViewModel.Email,
                NomeUsuario = usuarioViewModel.NomeUsuario
            };
            _contasService.NovaConta(usuario);

            return usuarioViewModel;
        }
    }
}
