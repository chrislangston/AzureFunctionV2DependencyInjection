using System.IO;
using System.Threading.Tasks;
using ApplicationCore.Application.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationCore.Tests.Application.Claims
{
    [TestClass]
    public class PhoneClaimsManagerTests
    {
        [TestMethod]
        public async Task ManageClaimAsync_GivenNoValidationIssues_ThenTrueResultIsReturned()
        {
            //arrange
            var manager = new PhoneClaimsManager();

            //act
            var model = new PhoneClaimModel("fileName.txt", new MemoryStream());
            var result = await manager.ManageClaimAsync(model);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task ManageClaimAsync_GivenInvalidFileName_ThenInvalidDataExceptionIsThrown()
        {
            //arrange
            var manager = new PhoneClaimsManager();
            var model = new PhoneClaimModel(null, new MemoryStream());

            //Assert
            await Assert.ThrowsExceptionAsync<InvalidDataException>(async () =>
            {
                //act
                await manager.ManageClaimAsync(model);
            });
        }
    }
}
