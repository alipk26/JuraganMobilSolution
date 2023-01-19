using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal abstract class Vehicle
    {
        public abstract string noPol_noReg { get; set; }
        public abstract int year { get; set; }
        public abstract decimal price { get; set; }
        public abstract decimal tax { get; set; }
        public abstract int seat { get; set; }
  
    }
}
