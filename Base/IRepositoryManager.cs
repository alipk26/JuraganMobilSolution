using JuraganMobil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public ISummaryRepository Summary {get;}
    }
}
