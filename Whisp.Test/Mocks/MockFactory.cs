using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whisp.Application.Interfaces.Services;

namespace Whisp.Tests.Mocks
{
    public class MockFactory
    {
        public Mock CreateVehicleService()
        {
            var vehicleService = new Mock<IVehicleService>();
            vehicleService.Setup(x => x.GetVehicleById(1)).Returns(
                new Domain.Entities.VehicleRegistration()
                {
                    Id = 1,
                    UserId = 1,
                    RegistrationNumber = "EUF2834",
                    Make = "Mazda",
                    Model = "CX-5",
                    Year = 2018
                });

            return vehicleService;
        }
    }
}
