using Category.Models;
using Moq;
using Products.Handlers;
using Products.Queries;
using Products.Repository;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ProductsTest.Queries
{
    public class GetProductRequestHandlerTest
    {
        private readonly Mock<IProductServices> _mockRepo;

        public GetProductRequestHandlerTest() { _mockRepo = Mocks.MockRepository.GetProductService(); }

        [Fact]
        public async Task GetProdListTest()
        {
            var handler = new GetProductsHandler(_mockRepo.Object);

            var result = await handler.Handle(new GetAllProducts(),
                CancellationToken.None);

            result.ShouldBeOfType<List<EcomProducts>>();

            result.Count().ShouldBe(2);
        }
    }
}

