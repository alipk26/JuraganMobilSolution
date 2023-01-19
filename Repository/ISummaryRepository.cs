using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal interface ISummaryRepository
    {
        int GetTotalVehicle();
        decimal GetTotalIncomeVehicle();
        int GetTotalVehicle(string vehicle);
        decimal GetTotalIncomeVehicle(string vehicle);
    }
}
