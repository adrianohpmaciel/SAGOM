using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Vehicle
    {
        public int Id { get; private set; }
        public string LicensePlate { get; private set; } = null!;
        public string Country { get; private set; } = null!;
        public string? State { get; private set; }
        public short? Year { get; private set; }
        public string? BrandName { get; private set; }
        public string? ModelName { get; private set; }
        public int IdCostumer { get; private set; }

        public  Costumer IdCostumerNavigation { get; private set; } = null!;
        public  ICollection<CostumerService> CostumerServices { get; private set; }

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
