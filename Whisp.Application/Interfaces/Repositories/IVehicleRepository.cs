using System.Collections.Generic;
using Whisp.Domain.Entities;

namespace Whisp.Application.Interfaces.Repositories
{
    public interface IVehicleRepository
    {
        void Insert(VehicleRegistration vehicle);

        VehicleRegistration GetById(long id);

        VehicleRegistration GetByRegistrationNumber(string registrationNumber);

        List<VehicleRegistration> GetByUser(long userId);
    }
}
