using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Whisp.Application;
using Whisp.Application.Enum;
using Whisp.Application.Interfaces;
using Whisp.Application.Interfaces.Services;
using Whisp.Application.RequestModels;
using Whisp.Domain.Entities;

namespace Whisp.Api.Controllers
{
    public class VehicleController : BaseController
    {
        private readonly IVehicleService _vehicleService;
        private readonly IAppLogger _logger;

        public VehicleController(IVehicleService vehicleService, IAppLogger logger)
        {
            _vehicleService = vehicleService;
            _logger = logger;
        }

        [HttpPost]
        [Route("api/vehicle/register")]
        public HttpResponseMessage RegisterVehicle(VehicleRegisterRequest request)
        {
            VehicleRegisterResponse response;

            try
            {
                //TODO: Authenticate API key in header in base
                
                // Validate input
                if(!HasValue(request, request.UserId, request.Make, request.Model, request.RegistrationNumber, request.Year))
                {
                    return Request.CreateResponse(new GenericResponse(null, ResponseCodes.InvalidParam, ResponseMessages.InvalidParam));
                }

                // Perform Transaction
                response = _vehicleService.RegisterVehicle(request);
                
                // Send response
                return Request.CreateResponse(new GenericResponse(response, ResponseCodes.Success, ResponseMessages.Success));
            }
            catch (Exception ex)
            {
                _logger.Exception(ex);
                return Request.CreateResponse(new GenericResponse(null, ResponseCodes.Error, ResponseMessages.Error));
            }
        }

        [HttpGet]
        [Route("api/vehicle/{id}")]
        public HttpResponseMessage GetVehicle(long id)
        {
            VehicleRegistration response;

            try
            {
                //TODO: Authenticate API key
                
                // Validate input
                if (!HasValue(id))
                {
                    return Request.CreateResponse(new GenericResponse(null, ResponseCodes.InvalidParam, ResponseMessages.InvalidParam));
                }

                // Perform transaction
                response = _vehicleService.GetVehicleById(id);

                // Send response
                return Request.CreateResponse(new GenericResponse(response, ResponseCodes.Success, ResponseMessages.Success));
            }
            catch (Exception ex)
            {
                _logger.Exception(ex);
                return Request.CreateResponse(new GenericResponse(null, ResponseCodes.Error, ResponseMessages.Error));
            }
        }

        [HttpGet]
        [Route("api/vehicle-by-user/{userId}")]
        public HttpResponseMessage GetVehiclesByOwner(long userId)
        {
            List<VehicleRegistration> response;

            try
            {
                // Authenticate API key

                // Validate input
                if (!HasValue(userId))
                {
                    return Request.CreateResponse(new GenericResponse(null, ResponseCodes.InvalidParam, ResponseMessages.InvalidParam));
                }

                // Perform transaction
                response = _vehicleService.GetVehiclesByUser(userId);

                // Send response
                return Request.CreateResponse(new GenericResponse(response, ResponseCodes.Success, ResponseMessages.Success));
            }
            catch (Exception ex)
            {
                _logger.Exception(ex);
                return Request.CreateResponse(new GenericResponse(null, ResponseCodes.Error, ResponseMessages.Error));
            }
        }

    }
}
