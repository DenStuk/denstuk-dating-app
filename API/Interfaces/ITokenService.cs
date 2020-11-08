using API.Entitties;

namespace API.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
    }
}