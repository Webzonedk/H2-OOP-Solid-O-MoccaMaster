using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    //Interface to connect household appliances an ensure that they have a turn on and off function
    interface IOnOff
    {
        bool TurnOnOff();
    }
}
