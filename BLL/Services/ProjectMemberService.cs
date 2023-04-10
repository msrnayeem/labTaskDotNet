using BLL.DTOs;
using DAL.CodeFirst;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectMemberService
    {
        public static List<ProjectMemberDTO> GetProjectMember(int id)
        {
            // Get member from database
            var data = ProjectMemberRepo.GetProjectMember(id);
            return Convert(data.ToList());
        }

        public static List<ProjectMemberDTO> GetProjects()
        {
            // Get member from database
            var data = ProjectMemberRepo.GetAllProjects();
            return Convert(data.ToList());
        }

        public static bool AssignMember(ProjectMemberDTO info)
        {
            // Add member to database
            return ProjectMemberRepo.AssignMember(Convert(info));
        }


        static ProjectMemberDTO Convert(ProjectMember member)
        {
            return new ProjectMemberDTO()
            {
               Id = member.Id,
               ProjectId = member.ProjectId,
               MemberId = member.MemberId
            };
        }

        static ProjectMember Convert(ProjectMemberDTO member)
        {
            return new ProjectMember()
            {
                Id = member.Id,
                ProjectId = member.ProjectId,
                MemberId = member.MemberId

            };
        }
        static List<ProjectMemberDTO> Convert(List<ProjectMember> news)
        {
            return news.Select(x => Convert(x)).ToList();
        }
 
    }
}
