using System;



namespace ApiGateway.DTO
{
    public class LoginDTO
    {
        public int LoginId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string LoginRole { get; set; }
        public string UserEmail { get; set; }
    }
}
