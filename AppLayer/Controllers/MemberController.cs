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
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/member/getMembers")]
        public HttpResponseMessage GetMembers()
        {
            try
            {
                var data = MemberService.GetMembers();
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
        [HttpGet]
        [Route("api/member/getMembers")]
        public HttpResponseMessage GetMember(int id)
        {
            try
            {
                var data = MemberService.GetMember(id);
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
        [Route("api/member/addMember")]
        public HttpResponseMessage AddMember(MemberDTO member)
        {
            try
            {
                var data = MemberService.AddMember(member);
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
        [HttpPost]
        [Route("api/member/updateMember")]
        public HttpResponseMessage UpdateMember(MemberDTO member)
        {
            try
            {
                var data = MemberService.UpdateMember(member);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "updated");
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


        [HttpGet]
        [Route("api/member/deleteMember")]
        public HttpResponseMessage DeleteMember(int id)
        {
            try
            {
                var data = MemberService.RemoveMember(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "deleted");
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
        [HttpGet]
        [Route("api/member/GetMemberDAF")]
        public HttpResponseMessage GetMemberDAF(int id)
        {
            try
            {
                var data = MemberService.Get(id);
                if (data!= null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "not found");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
    }
}
