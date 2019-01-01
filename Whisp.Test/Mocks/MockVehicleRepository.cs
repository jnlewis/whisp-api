using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whisp.Application.Interfaces.Repositories;
using Whisp.Domain.Entities;

namespace Whisp.Tests.Mocks
{
    public class MockVehicleRepository : IVehicleRepository
    {
        public void Insert(VehicleRegistration vehicle)
        {
        }

        public VehicleRegistration GetById(long id)
        {
            return new VehicleRegistration()
            {
                Id = 1,
                UserId = 10001,
                Make = "Mazda",
                Model = "CX-5",
                RegistrationNumber = "ASD1235",
                Year = 2018
            };
        }

        public VehicleRegistration GetByRegistrationNumber(string registrationNumber)
        {
            return new VehicleRegistration()
            {
                Id = 1,
                UserId = 10001,
                Make = "Mazda",
                Model = "CX-5",
                RegistrationNumber = "ASD1235",
                Year = 2018
            };
        }

        public List<VehicleRegistration> GetByUser(long userId)
        {
            return new List<VehicleRegistration>()
            {
                new VehicleRegistration()
                {
                    Id = 1,
                    UserId = 10001,
                    Make = "Mazda",
                    Model = "CX-5",
                    RegistrationNumber = "ASD1235",
                    Year = 2018
                },
                new VehicleRegistration()
                {
                    Id = 2,
                    UserId = 10001,
                    Make = "Honda",
                    Model = "CRV",
                    RegistrationNumber = "RHD1234",
                    Year = 2014
                }
            };
        }
    }
}
