using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mono_Service.Models
{
    public abstract class ModelService : IVehicleService
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}