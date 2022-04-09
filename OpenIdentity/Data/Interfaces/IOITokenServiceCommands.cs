
namespace OpenIdentityData.Interfaces
{
	public interface IOITokenServiceCommands
	{
		Task<OITokenResponse> Create(OICreateTokenRequest request);
		Task<bool> Remove(OIRemoveTokenRequest request);
	}
}
