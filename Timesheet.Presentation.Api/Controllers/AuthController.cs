using System;
using Microsoft.AspNet.Mvc;
using Timesheet.Presentation.Api.Common;
using Timesheet.Presentation.Api.Models.Auth;

namespace Timesheet.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        [HttpPost]
        public Login.Response Login([FromBody]Login.Request model)
        {
            throw new NotImplementedException();
        }
    }
}
