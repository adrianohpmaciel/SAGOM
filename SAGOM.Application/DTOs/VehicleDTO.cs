using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class VehicleDTO
    {
        public int Id { get; private set; }
        public string LicensePlate { get; private set; } = null!;
        public string Country { get; private set; } = null!;
        public string? State { get; private set; }
        public short? Year { get; private set; }
        public string? BrandName { get; private set; }
        public string? ModelName { get; private set; }
        public int IdCostumer { get; private set; }

    }
}
