using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer.Controllers
{
    public class ProjectMemberController : ApiController
    {

        [HttpGet]
        [Route("api/projectMember/getProjectMembers")]
        public HttpResponseMessage GetProjectMember(int id)
        {
            try
            {
                var data = ProjectMemberService.GetProjectMember(id);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "No data found");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
  
        [HttpPost]
        [Route("api/projectMember/assignMember")]
        public HttpResponseMessage AssignMember(ProjectMemberDTO info)
        {
            try
            {
                var data = ProjectMemberService.AssignMember(info);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "member added");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "failed");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


    }
}
