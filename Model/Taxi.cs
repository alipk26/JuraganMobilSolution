using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class Taxi : Car
    {
        private int _order;
        private decimal _orderPerkm;
        private decimal _total;
        private DateOnly _transactionDate;
        private static int _count;

        public Taxi(string noPol_noReg, int year, decimal price, decimal tax, int seat, int order, decimal orderPerkm, DateOnly transactionDate) : base(noPol_noReg, year, price, tax, seat)
        {
            _order = order;
            _orderPerkm = orderPerkm;
            _total = _order * _orderPerkm;
            _transactionDate = transactionDate;
            _count++;
        }

        public int Order { get => _order; set => _order = value; }
        public decimal OrderPerkm { get => _orderPerkm; set => _orderPerkm = value; }
        public decimal Total { get => _total;}
        public DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }

        public static int Count() => _count;
    }
}
