
using Category.Models;
using System.Collections.Generic;
using System.Linq;

namespace Products.Repository
{
    public class ProductsServices : IProductServices
    {
        private readonly EcomContext _data;



        public ProductsServices(EcomContext data)
        {
            _data = data;
        }
        public IEnumerable<EcomProducts> addProduct(EcomProducts cust)
        {

            _data.EcomProducts.Add(cust);
            _data.SaveChanges();
            return getProducts();
        }

        public EcomProducts getProductsbyId(int id)
        {
            var usr = _data.EcomProducts.FirstOrDefault(o => o.ProductId == id);
            return usr;
        }

        public IEnumerable<EcomProducts> getProducts()
        {
            return _data.EcomProducts.ToList();
        }


    }

}
