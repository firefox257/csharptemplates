

namespace OpenIdentityDatabase.Models
{
	public  class OIToken 
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ? Id { get; set; }
		public string UserId { get; set; }
		public string Token { get; set; }
		public DateTime Create { get; set; }

	}
}
