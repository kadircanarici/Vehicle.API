using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Repository
{
    public class CarRepository
    {
        List<Car> CarList = new List<Car>()
        {
            new Car(){Id=0,Wheels= 4, Headlights = true, Color = "Red"},
            new Car(){Id=1,Wheels= 4, Headlights = true, Color = "Blue"},
            new Car(){Id=2,Wheels= 4, Headlights = true, Color = "Black"},
            new Car(){Id=3,Wheels= 4, Headlights = true, Color = "White"},
            new Car(){Id=4,Wheels= 4, Headlights = true, Color = "White"},
            new Car(){Id=5,Wheels= 6, Headlights = true, Color = "White"},
            
        };
        public IEnumerable<Car> GetCars()
        {
            return CarList;
        }
        public void Remove(Car car)
        {
            CarList.Remove(car);
        }


    }
}
