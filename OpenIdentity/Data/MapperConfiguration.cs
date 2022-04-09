using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIdentityData
{
	public class MapperConfiguration: Profile
	{
		public MapperConfiguration()
		{
			CreateMap<OIAddUserRequest, AddUserRequest>().ReverseMap();
			CreateMap<OICreateTokenRequest, CreateTokenRequest>().ReverseMap();
			CreateMap<OIGetTokenRequest, GetTokenRequest>().ReverseMap();
			CreateMap<OIGetUserRequest, GetUserRequest>().ReverseMap();
			CreateMap<OIRefreshTokenRequest, RefreshTokenRequest>().ReverseMap();
			CreateMap<OIRemoveTokenRequest, RemoveTokenRequest>().ReverseMap();
			CreateMap<OIRemoveUserRequest, RemoveUserRequest>().ReverseMap();
			CreateMap<OITokenResponse, TokenResponse>().ReverseMap();
			CreateMap<OIUpdateUserRequest, UpdateUserRequest>().ReverseMap();
			CreateMap<OIUserResponse, UserResponse>().ReverseMap();
			CreateMap<OIValidateTokenRequest, ValidateTokenRequest>().ReverseMap();
			CreateMap<OIValidateTokenResponse, ValidateTokenResponse>().ReverseMap();
			CreateMap<OIVerifyUserRequest, VerifyUserRequest>().ReverseMap();
		}
	}
}
