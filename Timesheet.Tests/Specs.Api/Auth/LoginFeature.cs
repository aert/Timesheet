using NUnit.Framework;

namespace Timesheet.Tests.Specs.Api.Auth
{
    public partial class LoginFeature
    {
        [Test]
        public void Successful_login()
        {
            Given_the_timesheet_api_is_running();
            When_the_user_posts_invalid_data_to_the_auth_login_url();
            Then_the_system_should_return_300_status_code();
        }
    }
}
