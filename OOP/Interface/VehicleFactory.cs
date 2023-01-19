using JuraganMobil.OOP.Base;
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
    internal class VehicleFactory : IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vhStruct)
        {
            return new SUV(vhStruct.NoPoliceReg, vhStruct.vehicleType, vhStruct.TransactionDate, vhStruct.Rent, vhStruct.DriverFee);
        }

        public Taxi CreateTaxi(VehicleRecord vhRecord)
        {
            return new Taxi(vhRecord.NoPoliceReg, vhRecord.vehicleType, vhRecord.TransactionDate, vhRecord.Order,vhRecord.OrderPerKM);
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            listVehicle.ForEach(x => System.Console.WriteLine(x));
        }

        public int GetTotalVehicle<T>(List<T> totalVehicle, VehicleType type)
        {
            var result = 0;

            if (type == VehicleType.ALL) result = totalVehicle.Count();
            else result = totalVehicle.OfType<VehicleBase>().Where(x => x.vehicleType == type).Count();
            return result;
        }
    }
}
