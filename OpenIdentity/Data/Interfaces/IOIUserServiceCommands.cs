using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenIdentityData.ServiceModels;

namespace OpenIdentityData.Interfaces
{
	public interface IOIUserServiceCommands
	{
		Task<bool> Add(OIAddUserRequest request);
		Task<bool> Update(OIUpdateUserRequest request);
		Task<bool> Remove(OIRemoveUserRequest request);
	}
}
