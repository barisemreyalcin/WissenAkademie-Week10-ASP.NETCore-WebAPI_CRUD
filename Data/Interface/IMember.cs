using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data.Interface
{
	public interface IMember // Repository
	{
		IEnumerable<Member> GetAllMembers(); 

		Member GetMember(int memberId);
		Member AddMember(Member member);
		//bool AddMember(Member member);
		//int AddMember(Member member);

		bool MemberAddRange(IEnumerable<Member> members);

		Member UpdateMember(int memberId, Member updateMember);
		Member DeleteMember(int memberId);
		Member DeleteMember(Member member);
	}
}
