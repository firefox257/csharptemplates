
namespace OpenIdentityData.ServiceModels
{
	public class OIUpdateUserRequest
	{
		public Guid Id { get; set; }
		public string PasswordHash { get; set; }
	}
}
