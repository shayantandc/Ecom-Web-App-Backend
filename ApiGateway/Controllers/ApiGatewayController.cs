using ApiGateway.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiGatewayController : ControllerBase
    {
        [HttpGet]
        [Route("allcategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var url = "https://localhost:44390/api/Category";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<IEnumerable<CategoryDTO>>(url);
            return Ok(content);

        }
        [HttpPost]
        [Route("getctaegorybyId")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var url = "https://localhost:44390/api/Category/" + id;
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<CategoryDTO>(url);
            return Ok(content);
        }

        [HttpPost]
        [Route("addcategory")]

        public async Task<IActionResult> AddCategory([FromBody] CategoryDTO category)
        {
            var url = "https://localhost:44390/api/Category";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, category);
            return Ok(content.Content.ReadFromJsonAsync<IEnumerable<CategoryDTO>>().Result);
        }
        [HttpGet]
        [Route("allcustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var url = "https://localhost:44373/api/Customers";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<IEnumerable<CustomersDTO>>(url);
            return Ok(content);

        }
        [HttpPost]
        [Route("getcustomerbyId")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var url = "https://localhost:44373/api/Customers/" + id;
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<CustomersDTO>(url);
            return Ok(content);
        }

    
        [HttpPost]
        [Route("getcustomerbyLoginId")]
        public async Task<IActionResult> GetCustomerByLoginId(int id)
        {
            var url = "https://localhost:44373/GetLogin/" + id;
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<CustomersDTO>(url);
            return Ok(content);
        }

    [HttpPost]
        [Route("addcustomer")]

        public async Task<IActionResult> AddCustomer([FromBody] CustomersDTO cust)
        {
            var url = "https://localhost:44373/api/Customers";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, cust);
            return Ok(content.Content.ReadFromJsonAsync<IEnumerable<CustomersDTO>>().Result);
        }
        [HttpGet]
        [Route("alllogin")]
        public async Task<IActionResult> GetAllLogins()
        {
            var url = "https://localhost:44359/api/Login";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<IEnumerable<LoginDTO>>(url);
            return Ok(content);

        }
        [HttpPost]
        [Route("getloginbyId")]
        public async Task<IActionResult> GetLoginById(string mail)
        {
            var url = "https://localhost:44359/api/Login/" + mail;
            using var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            if (content == null)
            {
                return Ok(content);

            }
            else
            {
                return Ok(content);
            }
        }

        [HttpPost]
        [Route("addlogin")]

        public async Task<IActionResult> AddLogin([FromBody] LoginDTO log)
        {
            var url = "https://localhost:44359/api/Login";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, log);
            return Ok(content.Content.ReadFromJsonAsync<LoginDTO>().Result);
        }

        [HttpGet]
        [Route("allorders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var url = "https://localhost:44397/api/Orders";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<IEnumerable<OrdersDTO>>(url);
            return Ok(content);

        }
        [HttpPost]
        [Route("getorderbyId")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var url = "https://localhost:44397/api/Orders/" + id;
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<OrdersDTO>(url);
            return Ok(content);
        }

        [HttpPost]
        [Route("addorder")]

        public async Task<IActionResult> AddOrders([FromBody] OrdersDTO ord)
        {
            var url = "https://localhost:44397/api/Orders";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, ord);
            return Ok(content.Content.ReadFromJsonAsync<IEnumerable<OrdersDTO>>().Result);
        }

        [HttpGet]
        [Route("allproducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var url = "https://localhost:44388/api/Products";
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<IEnumerable<ProductsDTO>>(url);
            return Ok(content);

        }
        [HttpPost]
        [Route("getproductbyId")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var url = "https://localhost:44388/api/Products/" + id;
            using var client = new HttpClient();
            var content = await client.GetFromJsonAsync<ProductsDTO>(url);
            return Ok(content);
        }

        [HttpPost]
        [Route("addproduct")]

        public async Task<IActionResult> AddProduct([FromBody] ProductsDTO prod)
        {
            var url = "https://localhost:44388/api/Products";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, prod);
            return Ok(content.Content.ReadFromJsonAsync<IEnumerable<ProductsDTO>>().Result);
        }

        [HttpPost]
        [Route("payment")]
        public async Task<IActionResult> PostPayment([FromBody] PaymentDTO payment)
        {
            var url = "https://localhost:44368/api/Payment/AddPayment";
            using var client = new HttpClient();
            var content = await client.PostAsJsonAsync(url, payment);
            return Ok(content.Content.ReadFromJsonAsync<IEnumerable<PaymentDTO>>().Result);
        }



    }
}

