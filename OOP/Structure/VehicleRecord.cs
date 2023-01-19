using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Structure
{
    internal record VehicleRecord
    {
        public string? NoPoliceReg { get; set; }
        public VehicleType vehicleType { get; set; }
        public DateTime TransactionDate { get; set; }
        public Double Rent { get; set; }
        public double DriverFee { get; set; }
        public int Order { get; set; }
        public double OrderPerKM { get; set; }


    }
}
