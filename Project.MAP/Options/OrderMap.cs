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
    public  class OrderMap : BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Siparisler");
            Property(x => x.ShipperAddress).HasColumnName("Kullanıcı Rolü");
            Property(x => x.TotalPrice).HasColumnName("Toplam Ücret");

        }
    }
}
