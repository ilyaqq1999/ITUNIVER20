using System.Security.Claims;

using ItUniver.Runtime.Session;

using Microsoft.AspNetCore.Http;

namespace ItUniver.AspNetCore.Runtime.Session
{
    public class AspNetCorePrincipalAccessor : DefaultPrincipalAccessor
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public AspNetCorePrincipalAccessor(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public override ClaimsPrincipal Principal
        {
            get { return httpContextAccessor.HttpContext?.User ?? base.Principal; }
        }
    }
}