﻿using StuffAndThings.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuffAndThings.Data.Entities
{
    public class AddressEntity
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public StateEnum State { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string CEP { get; set; }
    }
}
