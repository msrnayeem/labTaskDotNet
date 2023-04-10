using DAL.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ProjectMemberRepo
    {
        static LabTaskEntities db;
        static ProjectMemberRepo()
        {
            db = new LabTaskEntities();
        }
        public static bool AssignMember(ProjectMember projectMember)
        {
            
                db.ProjectMembers.Add(projectMember);
                return db.SaveChanges() > 0;
            
        }
        public static bool RemoveProjectMember(int id)
        {
            
                var projectMember = db.ProjectMembers.Find(id);
                db.ProjectMembers.Remove(projectMember);
                return db.SaveChanges() > 0;
            
        }

        public static List<ProjectMember> GetProjectMember(int id)
        {
           
                return db.ProjectMembers.Where(p => p.ProjectId == id).ToList();
            
        }
        public static List<ProjectMember> GetAllProjects()
        {
            
                return db.ProjectMembers.ToList();
            
        }
    }
}
