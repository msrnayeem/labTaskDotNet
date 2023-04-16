using DAL.CodeFirst;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MemberRepoV2:Repo,IRepo<Member, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.Find(id);
        }

        public bool Insert(Member member)
        {
            db.Members.Add(member);
            return db.SaveChanges() > 0;

        }

        public bool Update(Member member)
        {
            throw new NotImplementedException();
        }

    }
}
