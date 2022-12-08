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
    public class ShipperMap : BaseMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kuryeler");
            Property(x => x.ShipperName).HasColumnName("Kurye Adi");
            Property(x => x.ShipperPhone).HasColumnName("Kurye Numarası");
        }
    }
}
