using DAL.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class MemberRepo
    {
        static LabTaskEntities db;
        static MemberRepo()
        {
            db = new LabTaskEntities();
        }
        public static List<Member> GetMembers()
        {
           return db.Members.ToList();
          
        }
        public static Member GetMember(int id)
        {
            return db.Members.FirstOrDefault(m => m.Id == id);
            
        }
        public static bool AddMember(Member member)
        {
            db.Members.Add(member);
            return db.SaveChanges() > 0;
            
        }
        public static bool DeleteMember(int id)
        {
            var memberToDelete = db.Members.FirstOrDefault(m => m.Id == id);
            db.Members.Remove(memberToDelete);
            return db.SaveChanges() > 0;
            
        }
        public static bool UpdateMember(Member member)
        {
            var data = db.Members.FirstOrDefault(p => p.Id == member.Id);
            data.Name = member.Name;
            data.Role = member.Role;
            return db.SaveChanges() > 0;
        }
    }
}
