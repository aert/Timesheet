namespace Timesheet.Presentation.Api.ApiModels.Auth
{
    public class Login
    {
        public class Request
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class Response
        {
            public string Token { get; set; }
        }
    }
}