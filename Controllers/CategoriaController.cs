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
    public class CategoriaController : Controller
    {
        private readonly ArmazenaCategoria _armazenaCategoria;
        private readonly IRepository<Categoria> _categoriaRepository;

        public CategoriaController(ArmazenaCategoria armazenaCategoria,
            IRepository<Categoria> categoriaRepository)
        {
            _armazenaCategoria = armazenaCategoria;
            _categoriaRepository = categoriaRepository;
        }
        
        private CategoriaViewModel categoriaId(int id)
        {
            var categoria = _categoriaRepository.GetById(id);
            var categoriaViewModel = new CategoriaViewModel { Id = categoria.Id, Name = categoria.CategEntradaSaida };
            return categoriaViewModel;
        }

        public IActionResult Index()
        {  
             return View();
        }
         public IActionResult Delete(int id)
        {
            var categoriaViewModel = categoriaId(id);
            return PartialView(categoriaViewModel);
        }

        [HttpPost]
         public IActionResult Delete(CategoriaViewModel viewModel)
        {            
            _armazenaCategoria.Deletar(viewModel.Id);
            return RedirectToAction("Index"); 
        }
                
        public IActionResult Create()
        {            
            return PartialView();            
        }
        
        [HttpPost]
         public IActionResult Create(CategoriaViewModel viewModel)
        {
            _armazenaCategoria.Armazenar(viewModel.Id, viewModel.Name);            
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {            
           var categoriaViewModel = categoriaId(id);
            return PartialView(categoriaViewModel);          
        }
        
        [HttpPost]
         public IActionResult Edit(CategoriaViewModel viewModel)
        {
            _armazenaCategoria.Armazenar(viewModel.Id, viewModel.Name);            
            return RedirectToAction("Index");
        }
    }
}

