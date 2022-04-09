
namespace OpenIdentityData.Api
{
	public class AddUserRequest
	{
		public string Name { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
	}
}
