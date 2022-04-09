
namespace OpenIdentityData.Api
{
	public class UserResponse
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime Create { get; set; }
		public DateTime? Modified { get; set; }
	}
}
