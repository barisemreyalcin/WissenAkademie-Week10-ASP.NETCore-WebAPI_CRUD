using Data.Interface;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCrud.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MemberController : ControllerBase
	{
		// Servisin methodlara erişebilmek için inject edeceğim
		private IMember memberRepo;

		public MemberController(IMember _memberRepo)
		{ 
			// Repodaki methodları controllerda artık kullanabilirim
			memberRepo = _memberRepo;
		}

		[HttpGet]
		public ActionResult<List<Member>> GetMembers()
		{
			return memberRepo.GetAllMembers().ToList();
		}

		[HttpGet]
		public ActionResult<Member> GetMemberById(int id)
		{
			return memberRepo.GetMember(id);
		}

	}
}
