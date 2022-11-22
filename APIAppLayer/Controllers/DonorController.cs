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
    public class DonorController : ApiController
    {
        [Route("api/donors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DonorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/donors/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = DonorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/donors/add")]
        [HttpPost]
        public HttpResponseMessage Add(DonorDTO obj)
        {
            var data = DonorService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/donors/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = DonorService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/donors/update/{id}")]
        [HttpPost]
        public HttpResponseMessage Update(int id, DonorDTO obj)
        {
            var data = DonorService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
