

namespace OpenIdentityService
{
	public class OIUserServiceCommands: IOIUserServiceCommands
	{
		protected IMapper Mapper { get; set; }
		protected OIDatabaseContext Db { get; set; }

		public OIUserServiceCommands(IMapper mapper, OIDatabaseContext db)
		{
			Mapper = mapper;
			Db = db;
		}
		public async Task<bool> Add(OIAddUserRequest request)
		{
			var users = Db.Users.ToList();
			var user = Db.Users.Where(u => u.Name == request.Name).FirstOrDefault();
			//var user = (from u in Db.Users where u.Name == request.Name select u).ToList();
			/*if(user != null)
			{
				throw new UserExistsException("User Exists");
			}
			var adduser = Mapper.Map<OIUser>(request);
			adduser.PasswordHash = Util.Hash(adduser.PasswordHash);
			adduser.Create = DateTime.Now;
			
			var response = await Db.Users.AddAsync(adduser);
			if(response == null)
			{
				throw new UserAddException("Could not add user.");
			}
			*/
			return true;
		}
		public async Task<bool> Update(OIUpdateUserRequest request)
		{
			throw new NotImplementedException();
		}
		public async Task<bool> Remove(OIRemoveUserRequest request)
		{
			throw new NotImplementedException();
		}
	}
}