using Category.Models;
using Moq;
using Products.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsTest.Mocks
{
    internal class MockRepository
    {
        public static Mock<IProductServices> GetProductService()
        {
            var prodlist = new List<EcomProducts>
            {
                new EcomProducts
                {
                    ProductId = 500,
                    CategoryId = 300,
                    ProductName = "H&M Hoodie",
                    ProductType="Hoodie",
                    ProductPrice = 8999,
                    ProductDescription ="Soft and Comfy"
                },

            };



            var mockrepo = new Mock<IProductServices>();



            mockrepo.Setup(r => r.getProducts()).Returns(prodlist);



            //mockrepo.Setup(r => r.AddCategory(It.IsAny<EcomCategory>()).Returns((EcomCategory category) =>
            //{
            //    catlist.Add(category);
            //    return catlist.SingleOrDefault(x => x.CategoryId == category.CategoryId);
            //});



            return mockrepo;
        }
    }
}

