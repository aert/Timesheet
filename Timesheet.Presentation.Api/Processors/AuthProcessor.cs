using System;
using Microsoft.AspNet.Mvc;
using Timesheet.Presentation.Api.Models.Auth;

namespace Timesheet.Presentation.Api.Processors
{
    public class AuthProcessor
    {
        public IActionResult AccessToken(AccessToken.Request model)
        {
            throw new NotImplementedException();
        }

        public IActionResult RefreshToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
