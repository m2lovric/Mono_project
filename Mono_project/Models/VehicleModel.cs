using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mono_project.Models
{
    public abstract class VehicleModel
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}