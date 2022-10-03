
using Category.Handlers;
using Category.Models;
using Category.Queries;
using Category.Repository;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Category.MicroService.Test.Queries
{
    public class GetCategoriesRequestHandlerTest
    {
        private readonly Mock<ICategory> _mockRepo;

        public GetCategoriesRequestHandlerTest() { _mockRepo = Mocks.MockRepository.GetCategoryService(); }

        [Fact]
        public async Task GetCategoryListTest()
        {
            var handler = new GetAllCategoryHandler(_mockRepo.Object);

            var result = await handler.Handle(new GetAllCategoryQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<EcomCategory>>();

            result.Count().ShouldBe(2);
        }
    }
}


