using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using SCIMAPITemplate.Models;

namespace SCIMAPITemplate.Controllers
{
    public class ServiceProviderConfigsController : ApiController
    {
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            // change values as needed
            ServiceProviderConfig config = new ServiceProviderConfig();
            config.schemas = new List<string>();
            config.schemas.Add("urn:scim:schemas:core:2.0:ServiceProviderConfig");
            config.documentationUrl = "http://example.com/help/scim.html";
            config.patch.supported = true;
            config.bulk.supported = true;
            config.bulk.maxOperations = 1000;
            config.bulk.maxPayloadSize = 1048576;
            config.filter.supported = true;
            config.filter.maxResults = 200;
            config.changePassword.supported = false;
            config.sort.supported = true;
            config.etag.supported = true;
            config.authenticationSchemes.Add(new AuthenticationScheme
            {
                name = "OAuth Bearer Token",
                description = "Authentication Scheme using the OAuth Bearer Token Standard",
                specUrl = "http://tools.ietf.org/html/draft-ietf-oauth-v2-bearer-01",
                documentationUrl = "http://example.com/help/oauth.html",
                type = "oauthbearertoken",
                primary = true
            });
            config.authenticationSchemes.Add(new AuthenticationScheme
            {
                name = "HTTP Basic",
                description = "Authentication Scheme using the Http Basic Standard",
                specUrl = "http://www.ietf.org/rfc/rfc2617.txt",
                documentationUrl = "http://example.com/help/httpBasic.html",
                type = "httpbasic"
            });
            config.meta = new ServiceProviderConfigMeta
            {
                location = "https://example.com/v2/ServiceProviderConfig",
                resourceType = "",
                created = "",
                lastModified = "",
                version = ""
            };

            return request.CreateResponse(HttpStatusCode.OK, config);
        }
    }
}
