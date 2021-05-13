using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AgendaServico.Api.ViewModel;
using AgendaServico.Modelo;
using AgendaServico.Service.Persistencia.Interfaces;

namespace AgendaServico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : AuthBaseController
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService) =>
            _contatoService = contatoService;

        private static ContatoViewModel ParaView(Contato contato)
        {
            return new ContatoViewModel
            {
                Id = contato.Id,
                Email = contato.Email,
                Nome = contato.Nome,
                NumeroContato = contato.NumerContato.Select(t => new NumeroContatoViewModel
                {
                    Ddd = t.Ddd,
                    Numero = t.Numero,
                    IdCategoria = t.IdCategoria,
                    Id = t.Id,
                    TipoContato = (int)t.TipoContato
                }).ToList()
            };
        }

        private static Contato ParaModel(ContatoViewModel contatoViewModel)
        {
            return new Contato
            {
                Id = contatoViewModel.Id,
                Nome = contatoViewModel.Nome,
                Email = contatoViewModel.Email,
                NumerContato = contatoViewModel.NumeroContato.Select(t => new NumeroContato
                {
                    IdCategoria = t.IdCategoria,
                    Ddd = t.Ddd,
                    Numero = t.Numero,
                    TipoContato = (TipoContato)t.TipoContato
                }).ToList()
            };
        }

        [HttpPost]
        public ContatoViewModel NovoContato(ContatoViewModel contatoViewModel)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            Contato contato = ParaModel(contatoViewModel);
            contato = _contatoService.NovoContato(usuario, contato);

            return ParaView(contato);
        }

        [HttpPut]
        public ContatoViewModel AtualizarContato(ContatoViewModel contatoViewModel)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            Contato contato = ParaModel(contatoViewModel);
            contato = _contatoService.AtualizarContato(usuario, contato);

            return ParaView(contato);
        }

        [HttpDelete]
        public ContatoViewModel RemoverContato(ContatoViewModel contatoViewModel)
        {
            var usuario = this.HttpContext.User.Identity.Name;

            Contato contato = ParaModel(contatoViewModel);
            contato = _contatoService.RemoverContato(usuario, contato);

            return ParaView(contato);
        }

        [HttpGet]
        public List<ContatoViewModel> BuscarTodosContatos()
        {
            var usuario = this.HttpContext.User.Identity.Name;
            var contatos = _contatoService.BuscarContatos(usuario);

            return contatos.Select(t => ParaView(t)).ToList();
        }

    }
}
