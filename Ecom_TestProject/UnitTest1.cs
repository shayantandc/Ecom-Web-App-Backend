using Moq;
using Orders;
using Orders.Repository;
using System;
using Xunit;

namespace Ecom_TestProject
{


    public class UnitTest1
    {
        private readonly AddOrderRequest _request;
        private readonly Mock<IOrdersServices> _addorderRepositoryMock;
        private readonly AddOrderRequestProcessor _processor;
        //private object _addorderRepositoryMock;
        public UnitTest1()
        {
            _request = new AddOrderRequest
            {
                OrderId = 700,
                ProductId = 500,
                CustomerId = 0,
                OrderQuantity = 0,
                OrderPrice = 0,
                ShipmentAddress = null

            };
            _addorderRepositoryMock = new Mock<IOrdersServices>();
            _processor = new AddOrderRequestProcessor(_addorderRepositoryMock.Object);
        }


        [Fact]
        public void ShouldReturnOrderResultWithRequestValues()
        {
            // Act
            AddOrderResponse response = _processor.Add(_request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(_request.OrderId, response.OrderId);

        }

        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.Add(null));

            // Assert
            Assert.Equal("request", exception.ParamName);
        }

    }

}

