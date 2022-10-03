using Login.Models;
using System.Collections.Generic;

namespace Login.Repository
{
    public interface ILogin
    {
        public EcomLogin register(EcomLogin cust);
        public EcomLogin getUsersbyId(string mail);
        public IEnumerable<EcomLogin> getUsers();
        
    }
}
