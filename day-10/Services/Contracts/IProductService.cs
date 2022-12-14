using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetAllProductsWithDetails();

        Product GetOneProductById(int id);
        IEnumerable<Product> GetAllProducts(ProductRequestParameters p);
        IEnumerable<Product> GetAllProductsByCategoryId(int id);

        Product CreateOneProduct(ProductForInsertionDto productDto);

        ProductForUpdateDto GetOneProductForUpdate(int id);

        void UpdateForOneProduct(ProductForUpdateDto productDto);
        void DeleteOneProduct(int id);

    }
}
