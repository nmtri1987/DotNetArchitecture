using Solution.Domain.Domains;
using Solution.Model.Models;

namespace Solution.Application.Applications
{
	public sealed class AuthenticationApplication : BaseApplication, IAuthenticationApplication
	{
		public AuthenticationApplication(IAuthenticationDomain authentication)
		{
			Authentication = authentication;
		}

		private IAuthenticationDomain Authentication { get; }

		public string Authenticate(AuthenticationModel authentication)
		{
			return Authentication.Authenticate(authentication);
		}

		public void Logout(long userId)
		{
			Authentication.Logout(userId);
		}
	}
}
