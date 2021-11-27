using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TransportManager.Data.Repositories.Abstract;
using TransportManager.Domain;
using TransportManager.Models;
using TransportManager.Services.Abstract;

namespace TransportManager.Services
{
    public class VehiclesService : IVehiclesService
    {
        private readonly IVehiclesRepository _vehiclesRepository;
        private readonly IMapper _mapper;

        public VehiclesService(IVehiclesRepository vehiclesRepository, IMapper mapper)
        {
            _vehiclesRepository = vehiclesRepository ?? throw new ArgumentNullException(nameof(vehiclesRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Vehicle> GetVehicleAsync(int id, string userLogin)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            var vehicleEntity = await _vehiclesRepository.GetVehicleAsync(id);

            return _mapper.Map<Vehicle>(vehicleEntity);
        }

        public async Task<Vehicle> AddVehicleAsync(VehicleModel vehicleModel, string userLogin)
        {
            if (vehicleModel == null) throw new ArgumentNullException(nameof(vehicleModel));
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            var vehicle = _mapper.Map<Vehicle>(vehicleModel);
            vehicle.GovernmentNumber = vehicle.GovernmentNumber.ToUpper(); // для правильности переводим номер в верхний регистр
            var vehicleEntity = await _vehiclesRepository.AddVehicleAsync(vehicle);

            return _mapper.Map<Vehicle>(vehicleEntity);
        }

        public async Task<Vehicle> UpdateVehicleAsync(VehicleModel vehicleModel, string userLogin)
        {
            if (vehicleModel == null) throw new ArgumentNullException(nameof(vehicleModel));
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            var vehicle = _mapper.Map<Vehicle>(vehicleModel);
            vehicle.GovernmentNumber = vehicle.GovernmentNumber.ToUpper(); // для правильности переводим номер в верхний регистр
            var vehicleEntity = await _vehiclesRepository.UpdateVehicleAsync(vehicle);

            return _mapper.Map<Vehicle>(vehicleEntity);
        }

        public async Task<Vehicle> DeleteVehicleAsync(int id, string userLogin)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            var vehicleEntity = await _vehiclesRepository.DeleteVehicleAsync(id);

            return _mapper.Map<Vehicle>(vehicleEntity);
        }

        public async Task<List<Vehicle>> GetAllVehiclesAsync(string userLogin)
        {
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            return (await _vehiclesRepository.GetAllVehiclesAsync())
                                             .Select(entity => _mapper.Map<Vehicle>(entity))
                                             .ToList();
        }

        public async Task<Vehicle> RemoveVehicleAsync(int id, string userLogin)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (userLogin == null) throw new ArgumentNullException(nameof(userLogin));

            var vehicleEntity = await _vehiclesRepository.RemoveVehicleAsync(id);

            return _mapper.Map<Vehicle>(vehicleEntity);
        }
    }
}