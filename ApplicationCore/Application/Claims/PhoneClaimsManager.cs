using System.Threading.Tasks;
using ApplicationCore.Application.Interfaces.Claims;

namespace ApplicationCore.Application.Claims
{
    public class PhoneClaimsManager : IPhoneClaimsManager
    {

        public async Task<bool> ManageClaimAsync(PhoneClaimModel model)
        {
            return await Task.FromResult(true);
        }
    }
}
