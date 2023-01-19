using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class SUV : Car
    {
        private decimal _rent;
        private decimal _driver;
        private decimal _total;
        private DateOnly _transactionDate;
        private static int _count;

        public SUV(string noPol_noReg, int year, decimal price, decimal tax, int seat, decimal rent, decimal driver, DateOnly transactionDate) : base(noPol_noReg,year,price,tax,seat)
        {
            _rent = rent;
            _driver = driver;
            _total = _driver + _rent;
            _transactionDate = transactionDate;
            _count ++;
        }

        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; }
        public decimal Total { get => _total;}
        public DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public static int Count() => _count;
    }
}
