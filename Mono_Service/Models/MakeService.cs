using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mono_Service.Models
{
    public abstract class MakeService : IVehicleService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}