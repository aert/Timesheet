using System.Net;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;
using Timesheet.Presentation.Api.Common;
using Timesheet.Presentation.Api.Models.Auth;
using Timesheet.Presentation.Api.Processors;

namespace Timesheet.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        private readonly AuthProcessor _Proxy;

        public AuthController(AuthProcessor proxy)
        {
            _Proxy = proxy;
        }

        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AccessToken.Response))]
        [HttpPost]
        public IActionResult AccessToken([FromBody]AccessToken.Request model)
        {
            return _Proxy.AccessToken(model);
        }

        [SwaggerResponse(HttpStatusCode.Unauthorized, "User was not logged in.")]
        public IActionResult RefreshToken([FromBody] string token)
        {
            return _Proxy.RefreshToken(token);
        }
    }
}
