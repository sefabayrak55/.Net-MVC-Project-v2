﻿using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var categories = _manager.CategoryService.GetAllCategories();  
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateOneCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOneCategory(Category category)
        {
            if (category is null)
                throw new Exception();

            //if (ModelState.IsValid)
            //{
                //_manager.CategoryService.Create(category);
                //_manager.Save();
                _manager.CategoryService.CreateOneCategory(category);
                return RedirectToAction("Index");
            //}

            //return View();
        }

        [HttpGet]
        public IActionResult UpdateOneCategory(int id)
        {
            var category = _manager.CategoryService.GetOneCategoryById(id);
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateOneCategory(Category category)
        {
            if (category is null)
                throw new Exception();

            if (ModelState.IsValid)
            {
                _manager.CategoryService.UpdateOneCategory(category);
                //_manager.Save();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteOneCategory(int id)
        {
            //_manager.CategoryService.Delete(new Category { CategoryId = id });
            //_manager.Save();

            _manager.CategoryService.DeleteOneCategory(id);
            return RedirectToAction("Index");
        }
    }
}
