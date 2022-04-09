using System.Security.Cryptography;

namespace OpenIdentityService.Utilities
{
	internal class Util
	{
		public static string Hash(string pass)
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
