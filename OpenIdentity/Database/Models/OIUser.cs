
namespace OpenIdentityDatabase.Models
{
	public  class OIUser
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ? Id { get; set; }
		[BsonElement("Name")]
		public string Name { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
		public bool EmailVerified { get; set; }
		/*public DateTime Create { get; set; }
		public DateTime? Modified { get; set; }*/

	}
}
