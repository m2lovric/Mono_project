using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mono_project.Models
{
    public abstract class VehicleMake : IVehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}