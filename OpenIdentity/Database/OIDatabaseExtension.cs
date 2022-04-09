
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace OpenIdentityDatabase
{
	public static class OIDatabaseExtension
	{
		public static void AddOIDatabaseContext(this IServiceCollection services, IConfiguration configuration)
		{
			/*var uri = configuration.GetValue<string>("couchdburi");
			var admin = configuration.GetValue<string>("couchdbadmin");
			var pass = configuration.GetValue<string>("couchdbpass");
			services.AddCouchContext<OIDatabaseContext>(builder => builder
				.UseEndpoint(uri)
				.UseBasicAuthentication(username: admin, password: pass)
				.EnsureDatabaseExists());*/
		}
	}

}
