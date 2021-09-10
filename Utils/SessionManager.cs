using Microsoft.AspNetCore.Http;

namespace RocketElevator.Utils
{
    public class SessionManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void TestSet()
        {
            _session.SetString("Test", "MD");
        }

        public void TestGet()
        {
            var message = _session.GetString("Test");
        }
    }
}
