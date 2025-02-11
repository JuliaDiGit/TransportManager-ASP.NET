﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TransportManager.Domain;
using TransportManager.Entities;

namespace TransportManager.Data.Repositories.Abstract
{
    public interface IVehiclesRepository
    {
        Task<VehicleEntity> GetVehicleAsync(int id);
        Task<VehicleEntity> AddVehicleAsync(Vehicle vehicle);
        Task<VehicleEntity> UpdateVehicleAsync(Vehicle vehicle);
        Task<VehicleEntity> DeleteVehicleAsync(int id);
        Task<List<VehicleEntity>> GetAllVehiclesAsync();
        Task<VehicleEntity> RemoveVehicleAsync(int id);
    }
}