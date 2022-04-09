
namespace OpenIdentityData.Api
{
	public class UpdateUserRequest
	{
		public Guid Id { get; set; }
		public string PasswordHash { get; set; }
	}
}
