
namespace OpenIdentityData.ServiceModels
{
	public class OIAddUserRequest
	{
		public string Name { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
	}
}
