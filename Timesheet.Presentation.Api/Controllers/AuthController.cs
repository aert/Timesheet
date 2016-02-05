using System;
using Microsoft.AspNet.Mvc;
using Timesheet.Presentation.Api.ApiModels.Auth;
using Timesheet.Presentation.Api.Common;

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
