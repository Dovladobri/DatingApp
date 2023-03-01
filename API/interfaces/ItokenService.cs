

using API.Entities;

namespace API.interfaces
{
    public interface ItokenService
    {
        string CreateToken(AppUser user);
    }
}