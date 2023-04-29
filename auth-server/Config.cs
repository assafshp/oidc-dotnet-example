using IdentityServer4.Models;
namespace IdentityServer
{
    public static class Config {
        public static IEnumerable < ApiScope > ApiScopes => new List < ApiScope > {
            new ApiScope("testapis", "Test API Scope")
        };
        public static IEnumerable < Client > Clients => new List < Client > {
            new Client {
                ClientId = "oidc",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("testsecret".Sha256())
                    },
                    AllowedScopes = {
                        "testapis"
                    },
                    AccessTokenLifetime = 3600
            }
        };
    }
}