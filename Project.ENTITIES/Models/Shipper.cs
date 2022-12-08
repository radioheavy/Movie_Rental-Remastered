﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Shipper : BaseEntity
    {
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }
    }
}
