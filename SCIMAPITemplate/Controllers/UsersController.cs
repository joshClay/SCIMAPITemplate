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
    public class UsersController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetUser(HttpRequestMessage request, string id)
        {
            User user = new User();
            // get user from your application here

            // if user is not found in application, return 404
            if (user == null)
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.OK, user);
            }
        }

        [HttpPut]
        public HttpResponseMessage PutUser(HttpRequestMessage request, User user)
        {
            // get user from application for comparision
            // User appUser = <application.getUser();>

            // if user.active is false in okta, true in app, deactivate user in app (optional)
            // if (!user.active && appUser.active) { do stuff; }

            // if user.active is true in okta, false in app, activate user in app (optional)
            // if (user.active && !appUser.active) { do stuff; }

            // if user.active is true in okta, true in app, compare fields for update, update accordingly
            // if (user.active && appUser.active) { do stuff; }

            return request.CreateResponse(HttpStatusCode.OK, user);
        }

        [HttpGet]
        public HttpResponseMessage GetUsers(HttpRequestMessage request, int startIndex, int count)
        {
            List<User> users = new List<Models.User>();

            // get all users from applcation
            // foreach app user { users.Add(user); }

            UserList list = new UserList();
            list.schemas = new List<string>();
            list.schemas.Add("urn:scim:schemas:core:1.0");
            list.totalResults = users.Count();
            list.Resources = users;
            return request.CreateResponse(HttpStatusCode.OK, list);
        }

        [HttpGet]
        public HttpResponseMessage GetUsers(HttpRequestMessage request, string filter, int startIndex, int count)
        {
            List<User> users = new List<Models.User>();

            // get filtered users from applcation
            // foreach app user { users.Add(user); }

            UserList list = new UserList();
            list.schemas = new List<string>();
            list.schemas.Add("urn:scim:schemas:core:1.0");
            list.totalResults = users.Count();
            list.Resources = users;

            if (users.Count > 0)
            {
                return request.CreateResponse(HttpStatusCode.OK, list);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostUser(HttpRequestMessage request, User user)
        {
            // add user to application

            return request.CreateResponse(HttpStatusCode.OK, user);
        }
    }
}
