using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Repository
{
    public class BusRepository
    {
        List<Bus> BusList = new List<Bus>()
        {
            new Bus(){Id=0,Color = "Red"},
            new Bus(){Id=1,Color = "Blue"},
            new Bus(){Id=2,Color = "Black"},
            new Bus(){Id=3,Color = "White"},
        };
        public IEnumerable<Bus> GetBuses()
        {
            return BusList;
        }
    }
}
