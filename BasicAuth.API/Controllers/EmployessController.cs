using BasicAuth.API.BasicAuth;
using BasicAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicAuth.API.Controllers
{
    [RoutePrefix("api/empployees")]
    [BasicAuthenticationAttribute]
    public class EmployessController : ApiController
    {
        //GetFewEmployees

        [Route("GetFewEmployees")]
        [BasicAuthorizationAttribute(Roles = "User")]
        public HttpResponseMessage GetFewEmployees() 
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees().Where(e => e.Id < 3));
        }

        //GetMoreEmployees

        [Route("GetMoreEmployees")]
        [BasicAuthorizationAttribute(Roles = "Admin")]
        public HttpResponseMessage GetMoreEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees().Where(e => e.Id < 4));
        }

        //GetAllEmployees

        [Route("GetAllEmployees")]
        [BasicAuthorizationAttribute(Roles = "SuperAdmin")]
        public HttpResponseMessage GetAllEmployees()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Employee.GetEmployees());
        }
    }
}
