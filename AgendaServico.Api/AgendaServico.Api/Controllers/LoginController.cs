using AgendaServico.Modelo;
using AgendaServico.Service.Acesso.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string Login(Usuario usuario) =>
            _autenticacaoService.Login(usuario);
    }
}
