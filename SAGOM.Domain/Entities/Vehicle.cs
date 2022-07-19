using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? State { get; set; }
        public short? Year { get; set; }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public int IdCostumer { get; set; }

        public  Costumer IdCostumerNavigation { get; set; } = null!;
        public  ICollection<CostumerService> CostumerServices { get; set; }

        public Vehicle()
        {
            CostumerServices = new HashSet<CostumerService>();
        }

        public Vehicle(string licensePlate, string country, string state, short? year, string brandName, string modelName, int idCostumer)
        {
            CostumerServices = new HashSet<CostumerService>();
            LicensePlate = licensePlate;
            Country = country;
            State = state;
            Year = year;
            BrandName = brandName;
            ModelName = modelName;
            IdCostumer = idCostumer;
        }
    }
}
