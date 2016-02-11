using System;
using NUnit.Framework;
using Timesheet.Tests.Common;

namespace Timesheet.Tests.Unit.Api.Controllers
{
    public partial class AuthControllerTests : BaseTests
    {
        [Test]
        public void AccessToken_with_good_auth()
        {
            Given_the_auth_controller_is_available();
            When_I_call_AccessToken_with_good_auth();
            Then_I_should_get_an_accesstoken();
        }

        [Test]
        public void AccessToken_with_bad_auth()
        {
            Given_the_auth_controller_is_available();
            When_I_call_AccessToken_with_bad_auth();
            Then_I_should_not_get_an_accesstoken();
        }

        [Test]
        public void RefreshToken_with_good_token()
        {
            Given_the_auth_controller_is_available();
            When_I_call_RefreshToken_with_good_token();
            Then_I_should_get_a_new_accesstoken();
        }

        [Test]
        public void RefreshToken_with_bad_token()
        {
            Given_the_auth_controller_is_available();
            When_I_call_RefreshToken_with_bad_token();
            Then_I_should_not_get_a_new_accesstoken();
        }
    }
}
