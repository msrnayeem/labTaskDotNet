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
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/project/getProjects")]
        public HttpResponseMessage GetProjects()
        {
            try
            {
                var data = ProjectService.GetProjects();
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
        [Route("api/project/getProject")]
        public HttpResponseMessage GetProject(int id)
        {
            try
            {
                var data = ProjectService.GetProject(id);
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
        [Route("api/project/addProject")]
        public HttpResponseMessage AddProject(ProjectDTO project)
        {
            try
            {
                var data = ProjectService.AddProject(project);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "project added");
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
        [Route("api/project/updateProject")]
        public HttpResponseMessage UpdateProject(ProjectDTO project)
        {
            try
            {
                var data = ProjectService.UpdateProject(project);
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
        [Route("api/project/deleteProject")]
        public HttpResponseMessage DeleteProject(int id)
        {
            try
            {
                var data = ProjectService.RemoveProject(id);
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
        [Route("api/project/getByStatus")]
        public HttpResponseMessage GetByStatus(string status)
        {
            try
            {
                var data = ProjectService.GetProjectsByStatus(status);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
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
        [HttpGet]
        [Route("api/project/getByDate")]
        public HttpResponseMessage GetByDate(DateTime startDate, DateTime endDate)
        {
            if(startDate != null && endDate != null)
            {
                try
                {
                    var data = ProjectService.GetProjectsByDate(startDate, endDate);
                    if (data != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, data);
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
            return Request.CreateResponse(HttpStatusCode.BadRequest, "enddate must");
        }
        [HttpGet]
        [Route("api/project/getByDate")]
        public HttpResponseMessage GetByDate( DateTime endDate)
        {
            
                try
                {
                    var data = ProjectService.GetProjectsByDate(endDate);
                    if (data != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, data);
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
