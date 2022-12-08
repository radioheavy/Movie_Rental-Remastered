using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AwardMap : BaseMap<Award>
    {
        public AwardMap()
        {
            ToTable("Ödüller");
            Property(x => x.AwardName).HasColumnName("Odul Adi");
            Property(x => x.AwardDate).HasColumnName("Odul Tarihi");
        }
    }
}
