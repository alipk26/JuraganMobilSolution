using JuraganMobil.OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.OOP.Base
{
    internal abstract class VehicleBase
    {
        protected VehicleBase(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate)
        {
            NoPoliceReg = noPoliceReg;
            this.vehicleType = vehicleType;
            TransactionDate = transactionDate;
        }

        protected VehicleBase(string noPoliceReg, VehicleType vehicleType, DateTime transactionDate, Double Rent)
        {
            NoPoliceReg = noPoliceReg;
            this.vehicleType = vehicleType;
            TransactionDate = transactionDate;
            this.Rent = Rent;
        }

        public string? NoPoliceReg { get; set; }
        public VehicleType vehicleType { get; set; }
        public string? Year { get; set; }
        public double price { get; set; }
        public float Tax { get; set; }
        public int Seat { get; set; }
        public DateTime TransactionDate { get; set; }
        public Double Rent { get; set; }
        public decimal TotalIncome { get; set; }
        //public abstract string DisplayInfo();

        public override string ToString()
        {
            return
                $"No Police Reg     : {NoPoliceReg} \n" +
                $"Vehicel Type      : {vehicleType} \n" +
                $"Transaction Date  : {TransactionDate}";

        }

    }
}
