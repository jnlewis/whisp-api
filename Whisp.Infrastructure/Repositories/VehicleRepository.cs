using System;
using System.Collections.Generic;
using System.Linq;
using Whisp.Application.Interfaces;
using Whisp.Application.Interfaces.Repositories;
using Whisp.Domain.Entities;

namespace Whisp.Infrastructure.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private IDatabase _database;
        private IAppLogger _logger;

        public VehicleRepository(IDatabase database, IAppLogger logger)
        {
            _database = database;
            _logger = logger;
        }

        public void Insert(VehicleRegistration vehicle)
        {
            string sql = @"INSERT INTO vehicle_registration(UserId,RegistrationNumber,Make,Model,Year)
                            VALUES(@UserId,@RegistrationNumber,@Make,@Model,@Year)";
            
            _database.Execute(sql, 
                new {
                    vehicle.UserId,
                    vehicle.RegistrationNumber,
                    vehicle.Make,
                    vehicle.Model,
                    vehicle.Year
                });
        }

        public VehicleRegistration GetById(long id)
        {
            string sql = @"SELECT * FROM vehicle_registration WHERE Id=@id";

            var result = _database.Query<VehicleRegistration>(
                sql,
                new
                {
                    id = id
                }).FirstOrDefault();

            return result;
        }

        public VehicleRegistration GetByRegistrationNumber(string registrationNumber)
        {
            string sql = @"SELECT * FROM vehicle_registration WHERE RegistrationNumber=@registrationNumber";

            var result = _database.Query<VehicleRegistration>(
                sql,
                new
                {
                    registrationNumber = registrationNumber
                }).FirstOrDefault();

            return result;
        }

        public List<VehicleRegistration> GetByUser(long userId)
        {
            string sql = @"SELECT * FROM vehicle_registration WHERE UserId=@userId";

            var result = _database.Query<VehicleRegistration>(
                sql,
                new {
                    userId = userId
                }).ToList();

            return result;
        }
    }
}
