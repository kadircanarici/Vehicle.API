using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Models;
using Vehicle.Repository;

namespace Vehicle.Services
{
    public class ScopedService : IScopedService
    {
        private readonly BoatRepository _boat;
        private readonly CarRepository _car;
        private readonly BusRepository _bus;

        public ScopedService(CarRepository carRepository, BusRepository busRepository, BoatRepository boatRepository)
        {
            _car = carRepository;
            _bus = busRepository;
            _boat = boatRepository;

        }

        public IEnumerable<Boat> GetBoatList()
        {
            return _boat.GetBoats().ToList();
        }

        public IEnumerable<Bus> GetBusList()
        {
            return _bus.GetBuses().ToList();
        }

        public IEnumerable<Car> GetCarList()
        {
            return _car.GetCars().ToList() ;
        }
        public IEnumerable GetCarListByColor(string color)
        {
            List<Car> CarList = _car.GetCars().Where(x => x.Color == color).ToList();
            if (CarList.Count()!=0)
            {
                return CarList;
            }
            return "bu renkte araç bulunamadı";
        }
        public IEnumerable GetBusListByColor(string color)
        {
            List<Bus> BusList = _bus.GetBuses().Where(x => x.Color == color).ToList();
            if (BusList.Count() != 0)
            {
                return BusList;
            }
            return "bu renkte araç bulunamadı";
        }
        public IEnumerable GetBoatListByColor(string color)
        {
            List<Boat> BoatList = _boat.GetBoats().Where(x => x.Color == color).ToList();
            if (BoatList.Count() != 0)
            {
                return BoatList;
            }
            return "bu renkte araç bulunamadı";
        }


        public IEnumerable<string> ChangeCarHeadLight(int id)
        {
            var car = _car.GetCars().FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                yield return "araç bulunamadı";
            }
            else if (car.Headlights == true)
            {
                car.Headlights = false;
                yield return "aracın farları kapandı";
            }
            else
            {
                car.Headlights = true;
                yield return "aracın farları acıldı";
            }
        }

        public IEnumerable<string> DeleteCar(int id)
        {
            var car = _car.GetCars().FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                yield return "araç bulunamadı";
            }
            else
            {
                _car.Remove(car);
                yield return "araç başarıyla silindi";
            }
        }



    }
}
