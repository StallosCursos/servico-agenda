using AgendaServico.Modelo;
using AgendaServico.Service.Persistencia.Interfaces;
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
    public class ContatoController : AuthBaseController
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService) =>
            _contatoService = contatoService;

        [HttpPost]
        public Contato NovoContato(Contato contato)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            return _contatoService.NovoContato(usuario, contato);
        }

        [HttpPut]
        public Contato AtualizarContato(Contato contato)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            return _contatoService.AtualizarContato(usuario, contato);
        }

        [HttpDelete]
        public Contato RemoverContato(Contato contato)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            return _contatoService.RemoverContato(usuario, contato);
        }

        [HttpGet]
        public List<Contato> BuscarTodosContatos()
        {
            var usuario = this.HttpContext.User.Identity.Name;
            return _contatoService.BuscarContatos(usuario);
        }

    }
}
