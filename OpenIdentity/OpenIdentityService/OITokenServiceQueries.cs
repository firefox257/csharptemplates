using System.Security.Cryptography;

namespace OpenIdentityService
{
	public class OITokenServiceQueries: IOITokenServiceQueries
	{
		public async Task<OITokenResponse> Get(OIGetTokenRequest request)
		{
			throw new NotImplementedException();
		}
		public async Task<OITokenResponse> Refresh(OIRefreshTokenRequest request)
		{
			throw new NotImplementedException();
		}
		public async Task<OIValidateTokenResponse> Validate(OIValidateTokenRequest request)
		{
			throw new NotImplementedException();
		}

		protected string Hash(string pass)
		{
			using (var sha256 = SHA256.Create())
			{
				// Send a sample text to hash.  
				var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
				// Get the hashed string.  
				return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
			}
		}
	}
}
