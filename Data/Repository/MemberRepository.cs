using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interface;
using Data.Model;

namespace Data.Repository
{
	public class MemberRepository : IMember
	{
		List<Member> memberList = new List<Member>()
		{
			new Member()
			{
				MemberId = 1,
				FirstName = "John",
				LastName = "Doe",
				Email = "john.doe@contoso.com",
				Address = "New Jersey, USA"
			},
			new Member()
			{
				MemberId = 2,
				FirstName = "Jane",
				LastName = "Doe",
				Email = "jane.doe@contoso.com",
				Address = "Utah, USA"
			},
			new Member()
			{
				MemberId = 3,
				FirstName = "Mark",
				LastName = "Doe",
				Email = "mark.doe@contoso.com",
				Address = "Minnesota, USA"
			},
			new Member()
			{
				MemberId = 4,
				FirstName = "Tim",
				LastName = "Doe",
				Email = "tim.doe@contoso.com",
				Address = "Los Angeles, USA"
			}
		};
		public Member AddMember(Member member)
		{
			memberList.Add(member);
			return member;
		}

		public Member DeleteMember(int memberId)
		{
			Member member = memberList.FirstOrDefault(x => x.MemberId == memberId);
			memberList.Remove(member);
			return member;
		}

		public Member DeleteMember(Member member)
		{
			memberList.Remove(member);
			return member;
		}

		public IEnumerable<Member> GetAllMembers()
		{
			return memberList;
		}

		public Member GetMember(int memberId)
		{
			Member member = memberList.SingleOrDefault(x => x.MemberId == memberId);
			return member;
		}

		public bool MemberAddRange(IEnumerable<Member> members)
		{
			memberList.AddRange(members);
			return true;
		}

		public Member UpdateMember(int memberId, Member updateMember)
		{
			Member member = memberList.FirstOrDefault(x => x.MemberId == memberId);
			member.FirstName = updateMember.FirstName;
			member.LastName = updateMember.LastName;
			member.Email = updateMember.Email;
			member.Address = updateMember.Address;

			return member;
		}
	}
}
