using System.Collections.Generic;
using System.Linq;
using AgendaServico.InfraEstrutura;
using AgendaServico.Modelo;
using AgendaServico.Service.Exceptions;
using AgendaServico.Service.Persistencia.Interfaces;

namespace AgendaServico.Service.Persistencia
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaService(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public Categoria NovaCategoria(Categoria categoria)
        {
            var categoriaPersistida = _unitOfWork.categoriaRepository.BuscarCategorias().FirstOrDefault(t => t.Nome == categoria.Nome);

            if (categoriaPersistida != null)
                throw CategoriaException.CategoriaJaAdicionada;

            _unitOfWork.categoriaRepository.AdicionarCategoria(categoria);
            _unitOfWork.Commit();

            return categoria;
        }

        public Categoria AtualizarCategoria(Categoria categoria)
        {
            var categoriaPersistida = _unitOfWork.categoriaRepository.BuscarCategorias().FirstOrDefault(t => t.Id == categoria.Id);

            if (categoriaPersistida == null)
                throw CategoriaException.CategoriaNaoAdicionada;

            categoriaPersistida.Nome = categoria.Nome;

            _unitOfWork.categoriaRepository.AtualizarCategoria(categoriaPersistida);
            _unitOfWork.Commit();

            return categoria;
        }

        public List<Categoria> Categorias() => _unitOfWork.categoriaRepository.BuscarCategorias();

        public List<Categoria> CategoriasComecandoCom(string term)
        {
            if (string.IsNullOrEmpty(term))
                throw CategoriaException.TermoNaoInformadoConsulta;

            return _unitOfWork.categoriaRepository.BuscarCategorias().Where(t => t.Nome.StartsWith(term)).ToList();
        }
    }
}
