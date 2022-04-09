using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIdentityService
{
	public class MapperConfiguration: Profile
	{
		public MapperConfiguration()
		{
			CreateMap<OIAddUserRequest, OIUser>().ReverseMap();
			CreateMap<OIUserResponse, OIUser>().ReverseMap();
			CreateMap<OITokenResponse, OIToken>().ReverseMap();
		}
	}
}
