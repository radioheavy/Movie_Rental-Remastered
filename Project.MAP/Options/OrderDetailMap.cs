using Project.ENTITIES;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public  class OrderDetailMap : BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("Satislar");
            Property(x => x.TotalPrice).HasColumnName("Toplam Tutar");
            Property(x => x.Quantity).HasColumnName("Adet");

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.OrderID,
                x.MovieID
            });
        }
    }
}
