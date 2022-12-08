using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ScenaristMap : BaseMap<Scenarist>
    {
        public ScenaristMap()
        {
            ToTable("Senaristler");
            Property(x => x.FirstName).HasColumnName("Senarist Adi");
            Property(x => x.LastName).HasColumnName("Senarist Soyadi");
        }
    }
}
