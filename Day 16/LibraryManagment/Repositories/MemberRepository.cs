using LibraryManagement.Data;
using LibraryManagement.Entities;
using LibraryManagment;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Repositories
{
    public class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members
            };
        }

        public GenericResponse<Member> GetMemberById(int id)
        {
            var member = DataStore.Members.FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found"
                };
            }
            return new GenericResponse<Member>
            {
                Success = true,
                Data = member
            };
        }

        public GenericResponse<List<Member>> SearchMembersByName(string name)
        {
            var members = DataStore.Members
                .Where(m => m.Name.IndexOf(name, System.StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members
            };
        }

        public GenericResponse<List<Member>> SearchMembersByEmail(string email)
        {
            var members = DataStore.Members
                .Where(m => m.Email.IndexOf(email, System.StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members
            };
        }
    }
}

