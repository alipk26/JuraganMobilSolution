using JuraganMobil.OOP.Enum;
using JuraganMobil.OOP.Model;
using JuraganMobil.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Interface
{
    internal interface IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vhStruct);

        public Taxi CreateTaxi(VehicleRecord vhRecord);

        public void DisplayVehicle <T> (List<T> listVehicle);
        public int GetTotalVehicle <T> (List<T> totalVehicle, VehicleType type);

    }
}
