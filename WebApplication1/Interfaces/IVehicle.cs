using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IVehicle
    {
        Response GetAllVehicles(VehicleRequestAPI requestAPI);
        Response GetVehicleById(VehicleRequestAPI requestAPI);
        Response GetVehicleByNumber(VehicleRequestAPI requestAPI);
        Response AddVehicle(VehicleRequestAPI requestAPI);
        Response UpdateVehicle(VehicleRequestAPI requestAPI);
        Response UpdateVehicleStatus(VehicleRequestAPI requestAPI);
    }
}
