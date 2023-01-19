using JuraganMobil.OOP.Base;
using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model
{
    internal class SUV : VehicleBase
    {
        public SUV(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double Rent, double driverFee = 0) : base(noPoliceReg, vehicleType, transactionDate, Rent)
        {
            DriverFee = driverFee;
            TotalIncome = (decimal)(driverFee + Rent);
        }
        public double DriverFee { get; set; }

        public override string ToString()
        {
            return base.ToString()+
            $"\nRent              : {Rent}" +
            $"\nDriver Fee        : {DriverFee}" +
            $"\nTotal Income      : {TotalIncome}";
        }
    }
}
