

namespace OpenIdentityService
{
	public class OIUserServiceQueries: IOIUserServiceQueries
	{
		protected IMapper Mapper { get; set; }
		protected OIDatabaseContext Db { get; set; }

		public OIUserServiceQueries(IMapper mapper, OIDatabaseContext db)
		{
			Mapper = mapper;
			Db = db;
		}
		public async Task<OIUserResponse> Get(OIGetUserRequest request)
		{
			



			throw new NotImplementedException(); 
		}
		public async Task<OITokenResponse> Verify(OIVerifyUserRequest request)
		{
			var user = (from u in Db.Users where u.Name == request.Name select u).FirstOrDefault();
			if(user == null)
			{
				throw new UnauthorizedAccessException();
			}
			var hash = Util.Hash(request.PasswordHash);
			if(user.PasswordHash != hash)
			{
				throw new UnauthorizedAccessException();
			}


			throw new NotImplementedException();
			
		}
	}
}
