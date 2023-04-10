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
    public class ProjectService
    {
        public static bool AddProject(ProjectDTO project)
        {
            // Add project to database
            return ProjectRepo.AddProject(Convert(project));
        }
        public static bool RemoveProject(int id)
        {
            // Remove project from database
            return ProjectRepo.DeleteProject(id);
        }

        public static bool UpdateProject(ProjectDTO project)
        {
            // Update project in database
            return ProjectRepo.UpdateProject(Convert(project));
        }

        public static List<ProjectDTO> GetProjects()
        {
            // Get project from database
            var data = ProjectRepo.GetProjects();
            return Convert(data.ToList());
        }

        public static ProjectDTO GetProject(int id)
        {
            // Get project from database
            var data = ProjectRepo.GetProject(id);
            return Convert(data);
        }

        public static List<ProjectDTO> GetProjectsByStatus(string status)
        {
            // Get project from database
            var data = ProjectRepo.GetProjectsByStatus(status);
            return Convert(data.ToList());
        }  
        public static List<ProjectDTO> GetProjectsByDate(DateTime startDate,DateTime endDate)
        {
            // Get project from database
            var data = ProjectRepo.GetProjectsByDate(startDate, endDate);
            return Convert(data.ToList());
        }   
        public static List<ProjectDTO> GetProjectsByDate(DateTime endDate)
        {
            // Get project from database
            var data = ProjectRepo.GetProjectsByDate(endDate);
            return Convert(data.ToList());
        }
        static ProjectDTO Convert(Project project)
        {
            return new ProjectDTO()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate
            };
        }

        static Project Convert(ProjectDTO project)
        {
            return new Project()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate
            };
        }
        static List<ProjectDTO> Convert(List<Project> project)
        {
            return project.Select(x => Convert(x)).ToList();
        }
    }
}
