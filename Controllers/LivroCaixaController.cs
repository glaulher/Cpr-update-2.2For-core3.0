using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cpr.Web.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using Cpr.Domain;
using Cpr.Domain.LivroCaixa;

namespace Cpr.Web.Controllers
{
    public class LivroCaixaController : Controller
    {

        private readonly ArmazenaLivroCaixa _armazenaLivroCaixa ;
        private readonly IRepository<LivroCaixa> _livroCaixaRepository;
        private readonly IRepository<Categoria> _categoriaRepository;

        public LivroCaixaController(ArmazenaLivroCaixa armazenaLivroCaixa,
            IRepository<LivroCaixa> livroCaixaRepository,
            IRepository<Categoria> categoriaRepository)
        {
            _armazenaLivroCaixa = armazenaLivroCaixa;
            _livroCaixaRepository = livroCaixaRepository;
            _categoriaRepository = categoriaRepository;
        }
      
        private LivroCaixaViewModel LivroCaixaId()
        {
            var livroCaixaViewModel = new LivroCaixaViewModel();
            var categoria = _categoriaRepository.All();
            livroCaixaViewModel.Categorias = categoria.Any()
                ? categoria.Select(c => new CategoriaViewModel { Id = c.Id, Name = c.CategEntradaSaida })
                : new List<CategoriaViewModel>();
            return livroCaixaViewModel;
        }
        public IActionResult Index()
        {           
          
            var livroCaixa = _livroCaixaRepository.All(); 
            if(livroCaixa.Any())
            {    
                var viewsModels = livroCaixa.Select(l => new LivroCaixaViewModel{ Id = l.Id, Tipo = l.Tipo,
                    CategoriaName = l.Categoria.CategEntradaSaida,
                    Data = l.Data, Descricao = l.Descricao, Valor = l.Valor});
                return View(viewsModels);
            }           
            return View();
        }

                  
        public IActionResult Create()
        {  
            var categoriaViewModel = LivroCaixaId();          
            return PartialView(categoriaViewModel);            
        }
        
        [HttpPost]
         public IActionResult Create(LivroCaixaViewModel viewModel)
        {
           
            _armazenaLivroCaixa.ArmazenarCaixa(viewModel.Id, viewModel.Tipo, viewModel.CategoriaId,
             viewModel.Data, viewModel.Descricao, viewModel.Valor);
            return RedirectToAction("Index");
        }

        /*
public IActionResult CreateOrEdit(int id)
{
   var viewModel = new ProductViewModel();
   var categories = _categoryRepository.All();
   viewModel.Categories = categories.Any()
       ? categories.Select(c => new CategoryViewModel {Id = c.Id, Name = c.Name})
       : new List<CategoryViewModel>();
   if (id > 0)
   {
       var product = _productRepository.GetById(id);
       viewModel.Id = product.Id;
       viewModel.Name = product.Name;
       viewModel.CategoryId = product.Category.Id;
       viewModel.Price = product.Price;
       viewModel.StockQuantity = product.StockQuantity;
       return View(viewModel);
   }
   return View(viewModel);

}

[HttpPost]
public IActionResult CreateOrEdit(ProductViewModel viewModel)
{
   _productStorer.Store(viewModel.Id, viewModel.Name, viewModel.CategoryId, viewModel.Price, viewModel.StockQuantity);
   return RedirectToAction("Index");
}
*/
    }
}

