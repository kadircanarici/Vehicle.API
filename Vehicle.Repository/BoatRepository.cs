using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Repository
{
    public class BoatRepository
    {
        List<Boat> BoatList = new List<Boat>()
        {
            new Boat(){Id=0,Color = "Red"},
            new Boat(){Id=1,Color = "Blue"},
            new Boat(){Id=2,Color = "Black"},
            new Boat(){Id=3,Color = "White"},
        };
        public IEnumerable<Boat> GetBoats()
        {
            return BoatList;
        }
    }
}
