using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whisp.Api.Controllers;
using Moq;
using Whisp.Application.Interfaces.Services;

namespace Whisp.Tests.Api.Controllers
{
    [TestClass()]
    public class VehicleControllerTests
    {
        [TestMethod()]
        public void GetVehicleTest()
        {
            var vehicleService = new Mock<IVehicleService>();
            vehicleService.Setup(x => x.GetVehicleById(1)).Returns(new Domain.Entities.VehicleRegistration()
            {

            })
            VehicleController controller = new VehicleController();

            Assert.Fail();
        }
    }
}