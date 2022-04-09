
namespace OpenIdentityData.Interfaces
{
	public interface IOITokenServiceQueries
	{
		Task<OITokenResponse> Get(OIGetTokenRequest request);
		Task<OITokenResponse> Refresh(OIRefreshTokenRequest request);
		Task<OIValidateTokenResponse> Validate(OIValidateTokenRequest request);
	}
}
