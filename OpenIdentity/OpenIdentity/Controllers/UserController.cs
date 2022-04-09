

namespace OpenIdentity.Controllers
{
	[Route("api/v1/[controller]/[action]")]
	[ApiController]
	public class UserController : Controller
	{
		protected IMapper Mapper { get; set; }
		protected IOIUserServiceCommands OIUserServiceCommands { get; set; }
		protected IOIUserServiceQueries OIUserServiceQueries { get; set; }
		public UserController(IMapper mapper, IOIUserServiceCommands oIUserServiceCommands, IOIUserServiceQueries oIUserServiceQueries)
		{
			Mapper = mapper;
			OIUserServiceCommands = oIUserServiceCommands;
			OIUserServiceQueries = oIUserServiceQueries;
		}

		[HttpPost, ActionName("add")]
		public async Task<IActionResult> Add([FromBody] AddUserRequest request)
		{

			try
			{
				var user = Mapper.Map<OIAddUserRequest>(request);
				await OIUserServiceCommands.Add(user);
			}
			catch (Exception ex)
			{
				return ex.CreateResponse();
			}

			return Ok();
		}
	}

}
