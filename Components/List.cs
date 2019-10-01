using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Cpr.Web.ViewsModels;
using Cpr.Domain;
using Cpr.Domain.LivroCaixa;

namespace Cpr.Web.Components
{
    public class List : ViewComponent
    {
        private readonly ArmazenaCategoria _armazenaCategoria;
        private readonly IRepository<Categoria> _categoriaRepository;

        public List(ArmazenaCategoria armazenaCategoria,
            IRepository<Categoria> categoriaRepository)
        {
            _armazenaCategoria = armazenaCategoria;
            _categoriaRepository = categoriaRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.All();     
             var viewsModels = categorias.Select(c => new CategoriaViewModel{ Id = c.Id, Name = c.CategEntradaSaida });
            return View(viewsModels);
        }
    }    
}