using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Category CreateOneCategory(Category category);
        void DeleteOneCategory(int id);
        IEnumerable<Category> GetAllCategories();
        Category GetOneCategoryById(int id);
        void UpdateOneCategory(Category category);
    }
}
