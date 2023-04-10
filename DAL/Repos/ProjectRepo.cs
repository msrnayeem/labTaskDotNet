using DAL.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ProjectRepo
    {
        static LabTaskEntities db;
        static ProjectRepo()
        {
            db = new LabTaskEntities();
        }
        public static List<Project> GetProjects()
        {
            return db.Projects.ToList();
            
        }
        public static Project GetProject(int id)
        {
           return db.Projects.FirstOrDefault(p => p.Id == id);
            
        }
        public static bool AddProject(Project project)
        {
            db.Projects.Add(project);
            return db.SaveChanges() > 0;
            
        }
        public static bool UpdateProject(Project project)
        {
            var projectToUpdate = db.Projects.FirstOrDefault(p => p.Id == project.Id);
            projectToUpdate.Title = project.Title;
                
            projectToUpdate.StartDate = project.StartDate;
            projectToUpdate.EndDate = project.EndDate;
            projectToUpdate.Status = project.Status;
             
            return db.SaveChanges() > 0;
            
        }
        public static bool DeleteProject(int id)
        {
            var projectToDelete = db.Projects.FirstOrDefault(p => p.Id == id);
            db.Projects.Remove(projectToDelete);
            return db.SaveChanges() > 0;
           
        }  
        
        public static List<Project> GetProjectsByStatus(string status)
        {
            return db.Projects.Where(p => p.Status == status).ToList();
        }        
        public static List<Project> GetProjectsByDate(DateTime startDate, DateTime endDate)
        {
            return db.Projects.Where(p => p.StartDate >= startDate && p.EndDate <= endDate).ToList();
        } 
        public static List<Project> GetProjectsByDate(DateTime endDate)
        {
            return db.Projects.Where(p => p.EndDate <= endDate).ToList();
        }
    }
}
