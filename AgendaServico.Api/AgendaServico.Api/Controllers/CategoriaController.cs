using AgendaServico.Modelo;
using AgendaServico.Service.Persistencia;
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
    }
}
