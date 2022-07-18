﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Client
    {
        public int Id { get; private set; }
        public Person Person { get; private set; }
        public ICollection<Vehicle> Vehicles { get; private set; }

        public Client(int id, Person person, ICollection<Vehicle> vehicles)
        {
            Id = id;
            Person = person;
            Vehicles = vehicles;
        }   
    }
}