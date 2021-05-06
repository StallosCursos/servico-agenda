using Microsoft.AspNetCore.Mvc;
using AgendaServico.Modelo;
using AgendaServico.Service.Acesso.Interfaces;

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
        public Usuario NovaConta(Usuario usuario) =>
            _contasService.NovaConta(usuario);
    }
}
