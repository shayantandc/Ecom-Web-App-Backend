
using Category.Models;
using System.Collections.Generic;

namespace Products.Repository
{
    public interface IProductServices
    {
        public IEnumerable<EcomProducts> addProduct(EcomProducts cust);
        public EcomProducts getProductsbyId(int id);
        public IEnumerable<EcomProducts> getProducts();

    }
}

