using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;

namespace AppInsightsAPIExample
{
    public class HttpContextRequestTelemetryInitializer : ITelemetryInitializer
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public HttpContextRequestTelemetryInitializer(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor =
                httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public void Initialize(Microsoft.ApplicationInsights.Channel.ITelemetry telemetry)
        {
            var requestTelemetry = telemetry as RequestTelemetry;
            if (requestTelemetry == null) return;

            var claims = this.httpContextAccessor.HttpContext.User.Claims;
            Claim oidClaim = claims.FirstOrDefault(claim => claim.Type == "oid");
            requestTelemetry.Properties.Add("UserOid", oidClaim?.Value);
        }
    }
}
