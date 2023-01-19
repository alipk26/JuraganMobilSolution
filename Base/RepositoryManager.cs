using JuraganMobil.Collection;
using JuraganMobil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal class RepositoryManager : IRepositoryManager
    {
        private ISummaryRepository _summary;
        private IVehicleCollection _vehicles;

        public RepositoryManager(IVehicleCollection vehicles)
        {
            _vehicles = vehicles;
        }

        public ISummaryRepository Summary
        {
            get
            {
                if (_summary is null)
                    _summary = new SummaryRepository(_vehicles);
                return _summary;
            }
        }
    }
}
