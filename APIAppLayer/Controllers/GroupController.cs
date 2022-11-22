using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAppLayer.Controllers
{
    public class GroupController : ApiController
    {
        [Route("api/groups")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = GroupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }

        [Route("api/groups/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = GroupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/add")]
        [HttpPost]
        public HttpResponseMessage Add(GroupDTO obj)
        {
            var data = GroupService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = GroupService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/update/{id}")]
        [HttpPost]
        public HttpResponseMessage Update(int id,GroupDTO obj)
        {
            var data = GroupService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
