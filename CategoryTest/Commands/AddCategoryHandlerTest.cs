using Category.Commands;
using Category.Handlers;
using Category.Models;
using Category.Repository;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
namespace Category.MicroService.Test.Commands
{
    public class AddCategoryHandlerTest
    {
        private readonly Mock<ICategory> _mockRepo;
        private readonly EcomCategory _category;



        public AddCategoryHandlerTest()
        {
            _mockRepo = Mocks.MockRepository.GetCategoryService();



            _category = new EcomCategory
            {
                CategoryId = 300,
                CategoryName = "Dress"
            };
        }



        [Fact]
        public async Task AddCategoryTest()
        {
            var handler = new AddCategoryHandler(_mockRepo.Object);



            var result = handler.Handle(new AddCategoryCommand { CategoryName = _category }, CancellationToken.None);



            var category = _mockRepo.Object.GetAllCategory();



            await result.ShouldBeOfType<Task<IEnumerator<EcomCategory>>>();



            category.Count().ShouldBe(3);
        }
    }
}



