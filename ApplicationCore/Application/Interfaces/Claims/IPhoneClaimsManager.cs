using System.Threading.Tasks;
using ApplicationCore.Application.Claims;

namespace ApplicationCore.Application.Interfaces.Claims
{
    public interface IPhoneClaimsManager
    {

        Task<bool> ManageClaimAsync(PhoneClaimModel model);

    }
}
