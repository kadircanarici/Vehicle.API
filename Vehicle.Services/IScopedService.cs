using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Services
{
    public interface IScopedService
    {
        public IEnumerable<Car> GetCarList();
        public IEnumerable GetCarListByColor(string color);
        public IEnumerable<Bus> GetBusList();
        public IEnumerable GetBusListByColor(string color);
        public IEnumerable<Boat> GetBoatList(); 
        public IEnumerable GetBoatListByColor(string color);
        public IEnumerable<string> ChangeCarHeadLight(int id);
        public IEnumerable<string> DeleteCar(int id);

    }
}
