namespace Timesheet.Presentation.Api.Models.Auth
{
    public class AccessToken
    {
        public class Request
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public string ClientId { get; set; }
        }

        public class Response
        {
            public string AccessToken { get; set; }
            public string TokenType { get; set; }
            public string UserId { get; set; }
        }
    }
}