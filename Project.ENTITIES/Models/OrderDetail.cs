﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class OrderDetail : BaseEntity
    {
        public int OrderID { get; set; }
        public int MovieID { get; set; }

        public decimal TotalPrice { get; set; }
        public short Quantity { get; set; }

        //Relational Properties
        public virtual Order Order { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
