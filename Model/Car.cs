using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class Car: Vehicle
    {
        private string _noPol_noReg;
        private int _year;
        private decimal _price;
        private decimal _tax;
        private int _seat;

        public Car(string noPol_noReg, int year, decimal price, decimal tax, int seat)
        {
            _noPol_noReg = noPol_noReg;
            _year = year;
            _price = price;
            _tax = tax;
            _seat = seat;
        }

        public override string noPol_noReg { get => _noPol_noReg; set => _noPol_noReg = value; }
        public override int year { get => _year; set => _year = value; }
        public override decimal price { get => _price; set => _price = value; }
        public override decimal tax { get => _tax; set => _tax = value; }
        public override int seat { get => _seat; set => _seat = value; }


        public override string ToString()
        {
            return
                $"Nopol/Noreg   : {noPol_noReg} \n" +
                $"Year          : {year} \n" +
                $"Price         : {price} \n" +
                $"Tax(InYear)   : {tax} \n" +
                $"Seat          : {seat} \n" ;
        }
    }
}
