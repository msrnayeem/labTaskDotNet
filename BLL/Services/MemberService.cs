using BLL.DTOs;
using DAL;
using DAL.CodeFirst;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MemberService
    {
        public static bool AddMember(MemberDTO member)
        {
            // Add member to database
            return MemberRepo.AddMember(Convert(member));
           
        }
        public static bool RemoveMember(int id)
        {
            // Remove member from database
            return MemberRepo.DeleteMember(id);
           
        }
        public static bool UpdateMember(MemberDTO member)
        {
            // Update member in database
            
            return MemberRepo.UpdateMember(Convert(member));
        }
        public static List<MemberDTO> GetMembers()
        {
            // Get member from database
            var data = MemberRepo.GetMembers();
            return Convert(data.ToList());
        }

        public static MemberDTO GetMember(int id)
        {
            // Get member from database
            var data = MemberRepo.GetMember(id);
            return Convert(data);
        }

        static MemberDTO Convert(Member member)
        {
            return new MemberDTO()
            {
               Id =member.Id,
               Name = member.Name,
               Role = member.Role
            };
        }

        static Member Convert(MemberDTO member)
        {
            return new Member()
            {
                Id = member.Id,
                Name = member.Name,
                Role = member.Role
            };
        }
        static List<MemberDTO> Convert(List<Member> member)
        {
            return member.Select(x => Convert(x)).ToList();
        }

        //INTERFACE
        public static MemberDTO Get(int id)
        {
            return Convert(DataAccessFactory.MemberData().Get(id));
        }
    }
}
