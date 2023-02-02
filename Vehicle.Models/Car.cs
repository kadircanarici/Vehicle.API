using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Models
{
    public class Car : VehicleBaseModel
    {
        public int Wheels { get; set; } 
        public bool Headlights { get; set; } = true;
    }
}
