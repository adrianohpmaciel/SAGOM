using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Vehicle
    {
        public string LicensePlate { get; private set; }
        public string Country { get; private set; }
        public string State { get; private set; }
        public int Year { get; private set; }
        public string BrandName { get; private set; }
        public string ModelName { get; private set; }
        public Client Owner { get; private set; }

        public Vehicle(string licensePlate, string country, string state, int year, string brandName, string modelName, Client owner)
        {
            LicensePlate = licensePlate;
            Country = country;
            State = state;
            Year = year;
            BrandName = brandName;
            ModelName = modelName;
            Owner = owner;
        }
    }
}
