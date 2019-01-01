using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whisp.Application.Interfaces;
using Whisp.Domain.Entities;
using Whisp.Infrastructure.Repositories;
using Whisp.Persistence;
using Whisp.Tests.Mocks;

namespace Whisp.Tests.Infrastructure.Repositories
{
    [TestClass]
    public class VehicleRepositoryTests
    {
        [TestMethod]
        public void InsertVehicleRegistrationTest()
        {
            IConfig config = new MockConfig();
            IAppLogger logger = new MockLogger();
            IDatabase database = new MySqlDatabase(config);

            long userId = DateTime.Now.Ticks;
            string registrationNumber = DateTime.Now.Ticks.ToString();
            string make = "Mazda";
            string model = "CX-5";
            int year = 2018;
            
            // Prepare entity
            VehicleRegistration request = new VehicleRegistration()
            {
                UserId = userId,
                RegistrationNumber = registrationNumber,
                Make = make,
                Model = model,
                Year = year
            };

            VehicleRepository vehicleRepository = new VehicleRepository(database, logger);
            vehicleRepository.Insert(request);
        }

        [TestMethod]
        public void GetVehicleByIdTest()
        {
            IConfig config = new MockConfig();
            IAppLogger logger = new MockLogger();
            IDatabase database = new MySqlDatabase(config);

            long id = 1;

            VehicleRepository vehicleRepository = new VehicleRepository(database, logger);
            var registration = vehicleRepository.GetById(id);

            Assert.IsNotNull(registration);
        }

        [TestMethod]
        public void GetVehicleRegistrationsByOwnerTest()
        {
            IConfig config = new MockConfig();
            IAppLogger logger = new MockLogger();
            IDatabase database = new MySqlDatabase(config);

            long userId = 1;

            VehicleRepository vehicleRepository = new VehicleRepository(database, logger);
            var registrations = vehicleRepository.GetByUser(userId);

            Assert.IsNotNull(registrations);
        }
    }
}
