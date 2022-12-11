using Entities.Models;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Category CreateOneCategory(Category category)
        {
            _manager.Category.Create(category);
            _manager.Save();
            return category;
        }

        public void DeleteOneCategory(int id)
        {
            var category = GetOneCategoryById(id);
            _manager.Category.Delete(category);
            _manager.Save();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _manager.Category.GetAllCategories();
            return categories;
        }

        public Category GetOneCategoryById(int id)
        {
            var category = _manager.Category.GetOneCategoryById(id);
            if (category is null)
                throw new Exception();
            return category;
        }

        public void UpdateOneCategory(Category category)
        {
            _manager.Category.Update(category);
            _manager.Save();
        }
    }
}
