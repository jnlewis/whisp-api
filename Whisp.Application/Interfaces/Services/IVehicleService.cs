using System.Collections.Generic;
using Whisp.Application.RequestModels;
using Whisp.Domain.Entities;

namespace Whisp.Application.Interfaces.Services
{
    public interface IVehicleService
    {
        VehicleRegisterResponse RegisterVehicle(VehicleRegisterRequest request);

        List<VehicleRegistration> GetVehiclesByUser(long userId);

        VehicleRegistration GetVehicleById(long id);
    }
}
