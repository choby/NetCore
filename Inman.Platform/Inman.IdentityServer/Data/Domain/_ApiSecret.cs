using IdentityServer4.Models;
namespace Inman.IdentityServer.Data.Domain
{
    public class _ApiSecret : Secret
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
      
    }
}
