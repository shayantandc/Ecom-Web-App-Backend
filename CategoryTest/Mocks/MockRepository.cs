using Category.Models;
using Category.Repository;
using Moq;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;



namespace Category.MicroService.Test.Mocks
{
    public static class MockRepository
    {
        public static Mock<ICategory> GetCategoryService()
        {
            var catlist = new List<EcomCategory>
            {
                new EcomCategory
                {
                    CategoryId = 300,
                    CategoryName = "Dress"
                },
                new EcomCategory
                {
                    CategoryId = 301,
                    CategoryName = "Shoes"
                }
            };



            var mockrepo = new Mock<ICategory>();



            mockrepo.Setup(r => r.GetAllCategory()).Returns(catlist);



            //mockrepo.Setup(r => r.AddCategory(It.IsAny<EcomCategory>()).Returns((EcomCategory category) =>
            //{
            //    catlist.Add(category);
            //    return catlist.SingleOrDefault(x => x.CategoryId == category.CategoryId);
            //});



            return mockrepo;
        }
    }
}

