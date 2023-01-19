using JuraganMobil.OOP.Base;
using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Model
{
    internal class Taxi : VehicleBase
    {
        public Taxi(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double order = 0, double orderPerKM = 0) : base(noPoliceReg, vehicleType, transactionDate)
        {
            Order = order;
            OrderperKM = orderPerKM;
            TotalIncome = (decimal)(order * orderPerKM);
        }

        public double Order { get; set; }
        public double OrderperKM { get; set; }
        public override string ToString()
        {
            return base.ToString() +
$"\nOrder             : {Order}" +
$"\nOrderPerKM        : {OrderperKM}" +
$"\nTotal Income      : {TotalIncome}"; 
        }
    }
}
