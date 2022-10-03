using Customers;
using Login.Repository;
using Moq;
using Orders.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ecom_TestProject
{
    public class UnitTestCustomer
    {
        private readonly AddCustomerRequest _request;
        private readonly Mock<ICustomerServices> _addcustomerRepositoryMock;
        //private readonly Mock<ICustomerServices>
        private readonly AddCustomerRequestProcessor _processor;

        public UnitTestCustomer()
        {
            _request = new AddCustomerRequest
            {
                CustomerId = 8,
                CustomerName = "Thejaswin",
                CustomerAddress = "Salem",
                //CustomerPhoneNumber = 9003554928
                CustomerEmailId = "Thejaswin@gmail.com",
                LoginId = 101

            };
            _addcustomerRepositoryMock = new Mock<ICustomerServices>();
            _processor = new AddCustomerRequestProcessor(_addcustomerRepositoryMock.Object);
        }


        [Fact]
        public void ShouldReturnOrderResultWithRequestValues()
        {
            // Act
            AddCustomerResponse response = _processor.Add(_request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(_request.CustomerId, response.CustomerId);

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



