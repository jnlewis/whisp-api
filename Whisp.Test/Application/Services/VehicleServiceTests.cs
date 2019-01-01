using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whisp.Application.Interfaces;
using Whisp.Application.Interfaces.Repositories;
using Whisp.Application.RequestModels;
using Whisp.Application.Services;
using Whisp.Tests.Mocks;

namespace Whisp.Tests.Application.Services
{
    [TestClass]
    public class VehicleServiceTests
    {
        [TestMethod]
        public void RegisterVehicleTest()
        {
            VehicleRegisterRequest request = new VehicleRegisterRequest();
            request.UserId = 1;
            request.RegistrationNumber = "ABD1234";
            request.Make = "Mazda";
            request.Model = "CX-5";
            request.Year = 2018;

            IAppLogger logger = new MockLogger();
            IVehicleRepository repository = new MockVehicleRepository();
            VehicleService vehicleService = new VehicleService(repository, logger);
            var registration = vehicleService.RegisterVehicle(request);

            Assert.IsNotNull(registration);
        }

        [TestMethod]
        public void GetVehiclesByUserTest()
        {
            int UserId = 1;

            IAppLogger logger = new MockLogger();
            IVehicleRepository repository = new MockVehicleRepository();
            VehicleService vehicleService = new VehicleService(repository, logger);
            var results = vehicleService.GetVehiclesByUser(UserId);

            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetVehicleByIdTest()
        {
            int VehicleId = 1;

            IAppLogger logger = new MockLogger();
            IVehicleRepository repository = new MockVehicleRepository();
            VehicleService vehicleService = new VehicleService(repository, logger);
            var result = vehicleService.GetVehicleById(VehicleId);

            Assert.IsNotNull(result);
        }
    }
}
