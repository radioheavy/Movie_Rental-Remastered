using Project.ENTITIES.Models;
using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ActorMap : BaseMap<Actor>
    {
        public ActorMap()
        {
            ToTable("Oyuncular");
            Property(x => x.FirstName).HasColumnName("Oyuncu Ismi");
            Property(x => x.LastName).HasColumnName("Oyuncu SoyIsmi");
        }
    }
}
