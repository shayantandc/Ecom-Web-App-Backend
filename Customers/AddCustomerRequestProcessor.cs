using Login.Models;
using Login.Repository;
using System;

namespace Customers
{
    public class AddCustomerRequestProcessor
    {
        private readonly ICustomerServices _addcustomerRepositoryMock;

        public AddCustomerRequestProcessor(ICustomerServices _addcustomerRepository)
        {
            _addcustomerRepositoryMock = _addcustomerRepository;
        }

        public AddCustomerResponse Add(AddCustomerRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            //_addorderRepositoryMock.Save(Create<AddOrder>(request));

            return Create<AddCustomerResponse>(request);
        }

        private static T Create<T>(AddCustomerRequest request) where T : EcomCustomers, new()
        {
            return new T
            {
                CustomerId = request.CustomerId,

            };
        }
    }



}

