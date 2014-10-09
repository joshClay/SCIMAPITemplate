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
    public class GroupsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetGroup(HttpRequestMessage request, string id)
        {
            Group group = new Group();
            // get group from app

            if (group != null)
            {
                return request.CreateResponse(HttpStatusCode.OK, group);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetGroups(HttpRequestMessage request, int startIndex, int count)
        {
            List<Group> groups = new List<Models.Group>();

            // get all groups from applcation
            // foreach app group { groups.Add(group); }

            GroupList list = new GroupList();
            list.schemas = new List<string>();
            list.schemas.Add("urn:scim:schemas:core:1.0");
            list.totalResults = groups.Count();
            list.Resources = groups;

            if (groups.Count > 0)
            {
                return request.CreateResponse(HttpStatusCode.OK, list);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetGroups(HttpRequestMessage request, string filter, int startIndex, int count)
        {
            List<Group> groups = new List<Models.Group>();

            // get filtered groups from applcation
            // foreach app group { groups.Add(group); }

            GroupList list = new GroupList();
            list.schemas = new List<string>();
            list.schemas.Add("urn:scim:schemas:core:1.0");
            list.totalResults = groups.Count();
            list.Resources = groups;

            if (groups.Count > 0)
            {
                return request.CreateResponse(HttpStatusCode.OK, list);
            }
            else
            {
                return request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostGroup(HttpRequestMessage request, Group group)
        {
            // create group in app

            return request.CreateResponse(HttpStatusCode.OK, group);
        }

        [HttpPut]
        public HttpResponseMessage PutGroup(HttpRequestMessage request, Group group)
        {
            // update group in app

            return request.CreateResponse(HttpStatusCode.OK, group);
        }
    }
}
