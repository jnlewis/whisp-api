using System;
using System.Collections.Generic;
using Whisp.Application.Interfaces;
using Whisp.Application.Interfaces.Repositories;
using Whisp.Application.Interfaces.Services;
using Whisp.Application.RequestModels;
using Whisp.Domain.Entities;

namespace Whisp.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IAppLogger _logger;

        public VehicleService(IVehicleRepository vehicleRepository, IAppLogger logger)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
        }

        public VehicleRegisterResponse RegisterVehicle(VehicleRegisterRequest request)
        {
            // Prepare entity
            VehicleRegistration model = new VehicleRegistration()
            {
                UserId = request.UserId,
                RegistrationNumber = request.RegistrationNumber,
                Make = request.Make,
                Model = request.Model,
                Year = request.Year
            };

            // Insert
            _vehicleRepository.Insert(model);

            // Get inserted ID
            long id = _vehicleRepository.GetByRegistrationNumber(request.RegistrationNumber).Id;

            // Prepare output
            VehicleRegisterResponse response = new VehicleRegisterResponse();
            response.VehicleRegistrationId = id;

            return response;
        }

        public List<VehicleRegistration> GetVehiclesByUser(long userId)
        {
            return _vehicleRepository.GetByUser(userId);
        }

        public VehicleRegistration GetVehicleById(long id)
        {
            return _vehicleRepository.GetById(id);
        }
    }
}
