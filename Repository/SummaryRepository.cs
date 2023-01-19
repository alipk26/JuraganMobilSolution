using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal class SummaryRepository : ISummaryRepository
    {
        IVehicleCollection _vehicle;

        public SummaryRepository(IVehicleCollection collection)
        {
            _vehicle = collection;
        }


        public decimal GetTotalIncomeVehicle()
        {
            decimal totalIncomeVehicle = 0;

            foreach (Vehicle vehicle in _vehicle.FetchAll())
            {
                if(vehicle is SUV)
                {
                    SUV sUV = (SUV)vehicle;
                    totalIncomeVehicle += sUV.Total;
                }

                if(vehicle is Taxi)
                {
                    Taxi taxi = (Taxi)vehicle;
                    totalIncomeVehicle += taxi.Total;
                }

                if(vehicle is PrivateJet)
                {
                    PrivateJet privateJet = (PrivateJet)vehicle;
                    totalIncomeVehicle += privateJet.Total;
                }
            }
            return totalIncomeVehicle;
        }

        public decimal GetTotalIncomeVehicle(string vehicle)
        {
            decimal totalIncomeVehicle = 0;
            foreach (Vehicle vc in _vehicle.FetchAll())
            {
                if (vehicle == "SUV" && vc.GetType().Name == vehicle)
                {
                    SUV sUV = (SUV)vc;
                    totalIncomeVehicle += sUV.Total;
                }

                if (vehicle == "Taxi" && vc.GetType().Name == vehicle)
                {
                    Taxi taxi = (Taxi)vc;
                    totalIncomeVehicle += taxi.Total;
                }

                if (vehicle == "PrivateJet" && vc.GetType().Name == vehicle )
                {
                    PrivateJet privateJet = (PrivateJet)vc;
                    totalIncomeVehicle += privateJet.Total;
                }
            }
            return totalIncomeVehicle;
        }

        public int GetTotalVehicle()
        {
            return _vehicle.FetchAll().Count();
        }

        public int GetTotalVehicle(string vehicle)
        {
            if (vehicle.Equals("SUV"))
                return SUV.Count();

            if (vehicle.Equals("Taxi"))
                return Taxi.Count();

            if (vehicle.Equals("PrivateJet"))
                return PrivateJet.Count();

            return 0;
        }
    }
}
