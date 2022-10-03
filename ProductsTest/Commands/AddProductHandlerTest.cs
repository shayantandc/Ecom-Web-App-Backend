//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ProductsTest.Commands
//{
//    internal class AddProductHandlerTest
//    {
//        private readonly Mock<IProductServices> _mockRepo;
//        private readonly EcomProducts _category;



//        public AddProductHandlerTest()
//        {
//            _mockRepo = Mocks.MockRepository.GetProductService();



//            _category = new EcomProducts
//            {
//                CategoryId = 300,
//                CategoryName = "Dress"
//            };
//        }



//        [Fact]
//        public async Task AddCategoryTest()
//        {
//            var handler = new AddCategoryHandler(_mockRepo.Object);



//            var result = handler.Handle(new AddCategoryCommand { CategoryName = _category }, CancellationToken.None);



//            var category = _mockRepo.Object.GetAllCategory();



//            await result.ShouldBeOfType<Task<IEnumerator<EcomCategory>>>();



//            category.Count().ShouldBe(3);
//        }
//    }
//}


