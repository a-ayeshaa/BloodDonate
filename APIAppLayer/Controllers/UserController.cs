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
    public class UserController : ApiController
    {
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO obj)
        {
            var data = UserService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(string id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/users/update/{id}")]
        [HttpPost]
        public HttpResponseMessage Update(string id, UserDTO obj)
        {
            var data = UserService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
