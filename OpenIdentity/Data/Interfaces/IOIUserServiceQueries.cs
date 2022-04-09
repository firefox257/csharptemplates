using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenIdentityData.ServiceModels;

namespace OpenIdentityData.Interfaces
{
	public interface IOIUserServiceQueries
	{
		Task<OIUserResponse> Get ( OIGetUserRequest request );
		Task<OITokenResponse> Verify(OIVerifyUserRequest request);
		
	}
}
