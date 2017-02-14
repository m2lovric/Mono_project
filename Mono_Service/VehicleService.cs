using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Mono_Service.Models;

namespace Mono_Service
{
    interface IVehicleService
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }

    public class VehicleService : DbContext
    {
        public DbSet<MakeService> Constructor { get; set; }
        public DbSet<ModelService> Models { get; set; }
    }
}