using System;
using System.IO;
using System.Threading.Tasks;
using ApplicationCore.Application.Interfaces.Claims;

namespace ApplicationCore.Application.Claims
{
    public class PhoneClaimsManager : IPhoneClaimsManager
    {

        public async Task<bool> ManageClaimAsync(PhoneClaimModel model)
        {
            if (string.IsNullOrEmpty(model.FileName))
            {
                throw new InvalidDataException("Filename cannot be null or empty");
            }

            return await Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromSeconds(1));
                return true;
            });
        }
    }
}
