using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    //Interface to use for implementation of different types of drinks
    interface IBrewType
    {
        public string Type { get; set; }
        public void Add();
    }
}
