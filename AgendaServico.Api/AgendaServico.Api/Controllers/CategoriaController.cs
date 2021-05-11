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
    public class CategoriaController : AuthBaseController
    {
        public readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService) =>
            _categoriaService = categoriaService;

        [HttpPost]
        public Categoria NovaCategoria(Categoria categoria) =>
            _categoriaService.NovaCategoria(categoria);

        [HttpGet]
        public List<Categoria> ListarCategorias() =>
            _categoriaService.Categorias();

        [HttpGet("{Term}")]
        public List<Categoria> ListarCategoriasCom(string Term) =>
            _categoriaService.CategoriasComecandoCom(Term);
    }
}
