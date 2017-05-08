using IdentityServer4.Models;

namespace Inman.IdentityServer.Data.Domain
{
    public class _ClientSecret : Secret
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
    }
}
