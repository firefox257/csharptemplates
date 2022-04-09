using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIdentityService
{
	public class OITokenServiceCommands: IOITokenServiceCommands
	{
		protected IMapper Mapper { get; set; }
		protected OIDatabaseContext Db { get; set; }
		public OITokenServiceCommands(IMapper mapper, OIDatabaseContext db)
		{
			Mapper = mapper; ;
			Db = db;
		}
		public async Task<OITokenResponse> Create(OICreateTokenRequest request)
		{
			


			throw new NotImplementedException();
		}
		public async Task<bool> Remove(OIRemoveTokenRequest request)
		{
			throw new NotImplementedException();
		}

	}
}
