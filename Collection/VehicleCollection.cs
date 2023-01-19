using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Collection
{
    internal class VehicleCollection : IVehicleCollection
    {
        private readonly List<Vehicle> _vehicle;

        public VehicleCollection()
        {
            _vehicle = new List<Vehicle>
            {
            new SUV("D 1001 UM", 2010, 350_000_000M, 3500_000M, 4, 500_000M, 150_000M, new DateOnly(2023, 01, 10)),
            new SUV("D 1002 UM", 2010, 350_000_000M, 3500_000M, 4, 500_000M, 150_000M, new DateOnly(2023, 01, 10)),
            new SUV("D 1003 UM", 2015, 350_000_000M, 3500_000M, 5, 500_000M, 150_000M, new DateOnly(2023, 01, 12)),
            new SUV("D 1004 UM", 2015, 350_000_000M, 3500_000M, 5, 500_000M, 150_000M, new DateOnly(2023, 01, 13)),
            new Taxi("D 11 UK", 2002, 175_000_000M, 1750_000M, 4, 45, 4500M, new DateOnly(2023, 01, 12)),
            new Taxi("D 12 UK", 2015, 225_000_000M, 2250_000M, 4, 75, 4500M, new DateOnly(2023, 01, 13)),
            new Taxi("D 13 UK", 2020, 275_000_000M, 2750_000M, 4, 90, 4500M, new DateOnly(2023, 01, 13)),
            new PrivateJet("ID8089", 2015, 150_000_000_000M, 1500_000_000M, 12, 35_000_000, 15_000_000M, new DateOnly(2023, 12, 23)),
            new PrivateJet("ID8099", 2018, 175_000_000_000M, 1750_000_000M, 15, 55_000_000, 25_000_000M, new DateOnly(2023, 12, 25))
            };
        }
            
        public List<Vehicle> FetchAll()
        {
            return _vehicle;
        }

    }
}
