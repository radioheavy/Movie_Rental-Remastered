using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DirectorMap : BaseMap<Director>
    {
        public DirectorMap()
        {
            ToTable("Yönetmenler");
            Property(x => x.FirstName).HasColumnName("Yonetmen Adi");
            Property(x => x.LastName).HasColumnName("Yonetmen Soyadi");
        }
    }
}
