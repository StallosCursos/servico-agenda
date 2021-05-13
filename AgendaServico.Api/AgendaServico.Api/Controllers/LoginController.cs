using AgendaServico.Api.ViewModel;
using AgendaServico.Modelo;
using AgendaServico.Service.Acesso.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgendaServico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAutenticacaoService _autenticacaoService;

        public LoginController(IAutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        [HttpPost]
        public RespostaLoginViewModel Login(LoginViewModel loginViewModel)
        {
            Usuario usuario = new Usuario { NomeUsuario = loginViewModel.NomeUsuario, Senha = loginViewModel.Senha };

            var Token =  _autenticacaoService.Login(usuario);

            return new RespostaLoginViewModel { Token = Token };
        }
    }
}
