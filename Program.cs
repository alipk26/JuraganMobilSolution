using JuraganMobil.Base;
using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.OOP.Base;
using JuraganMobil.OOP.Enum;
using JuraganMobil.OOP.Interface;
using JuraganMobil.OOP.Structure;
using JuraganMobil.Repository;
using System.Threading.Channels;

namespace JuraganMobil // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new VehicleCollection();
            var repositoryManager = new RepositoryManager(collection);

            //var subrepo = new SummaryRepository(collection);
            //subrepo.GetTotalIncomeVehicle();
            //Console.WriteLine("Total Vehicle SUV {0}", repositoryManager.Summary.GetTotalVehicle("SUV"));
            //Console.WriteLine("Total Vehicle Taxi {0}", repositoryManager.Summary.GetTotalVehicle("Taxi"));
            //Console.WriteLine("Total Vehicle PrivateJet {0}", repositoryManager.Summary.GetTotalVehicle("PrivateJet"));
            //Console.WriteLine();
            //Console.WriteLine("Total Vehicle: {0}", repositoryManager.Summary.GetTotalVehicle());
            //Console.WriteLine();
            //Console.WriteLine("Total Income Suv : {0}", repositoryManager.Summary.GetTotalIncomeVehicle("SUV"));
            //Console.WriteLine("Total Income Taxi : {0}", repositoryManager.Summary.GetTotalIncomeVehicle("Taxi"));
            //Console.WriteLine("Total Income PrivateJet : {0}", repositoryManager.Summary.GetTotalIncomeVehicle("PrivateJet"));
            //Console.WriteLine();
            //Console.WriteLine("Total Income All: {0}", repositoryManager.Summary.GetTotalIncomeVehicle());

            //call interface
            IVehicleFactory _IVehicle = new VehicleFactory();

            var suvHolder = new VehicleStruct
            {
                NoPoliceReg = "B 00 BS",
                vehicleType = VehicleType.SUV,
                TransactionDate = DateTime.Now,
                DriverFee = 150_000,
                Rent = 500_000
            };


            var taxiHolder = new VehicleRecord
            {
                NoPoliceReg = "B 1 NAL",
                vehicleType = VehicleType.TAXI,
                TransactionDate = DateTime.Now,
                DriverFee = 150_000,
                Order = 50,
                OrderPerKM = 5000
            };

            var suv = _IVehicle.CreateSUV(suvHolder);
            Console.WriteLine(suv);

            Console.WriteLine();

            var taxi = _IVehicle.CreateTaxi(taxiHolder);
            Console.WriteLine(taxi);

            Console.WriteLine();

            List<VehicleBase> list = new List<VehicleBase>() { suv, taxi };
            //_IVehicle.DisplayVehicle(list);

            Console.WriteLine(_IVehicle.GetTotalVehicle(list, VehicleType.ALL));

        }
    }
}