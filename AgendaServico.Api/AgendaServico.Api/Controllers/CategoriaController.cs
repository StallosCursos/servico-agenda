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
    public class CategoriaController : AuthBaseController
    {
        public readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService) =>
            _categoriaService = categoriaService;

        [HttpPost]
        public CategoriaViewModel NovaCategoria(CategoriaViewModel categoriaViewModel)
        {
            Categoria categoria = new Categoria { 
                Nome = categoriaViewModel.Nome
            };

            _categoriaService.NovaCategoria(categoria);

            return new CategoriaViewModel { Id = categoria.Id, Nome = categoria.Nome };
        }

        [HttpGet]
        public List<CategoriaViewModel> ListarCategorias()
        {
            return _categoriaService.Categorias().Select(t => new CategoriaViewModel { 
               Id = t.Id, 
               Nome = t.Nome
            }).ToList();
        }

        [HttpGet("{Term}")]
        public List<CategoriaViewModel> ListarCategoriasCom(string Term)
        {
            return _categoriaService.Categorias().Where(t => t.Nome.StartsWith(Term)).Select(t => new CategoriaViewModel
            {
                Id = t.Id,
                Nome = t.Nome
            }).ToList();
        }
    }
}
