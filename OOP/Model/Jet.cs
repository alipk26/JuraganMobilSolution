using JuraganMobil.OOP.Base;
using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model
{
    internal class Jet : VehicleBase
    {
        public Jet(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double Rent, double orderPerHours = 0) : base(noPoliceReg, vehicleType, transactionDate, Rent)
        {
            OrderPerHours = orderPerHours;
        }

        public double OrderPerHours { get; set; }
    }
}
