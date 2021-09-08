using Core.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace NorthWind.Data
{
    public class AppDbContext : ApiAuthorizationDbContext<User>
    {
        public AppDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(
            options, operationalStoreOptions)
        {
        }
    }
}