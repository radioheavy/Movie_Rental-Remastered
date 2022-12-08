using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieAwardMap : BaseMap<MovieAward>
    {
        public MovieAwardMap()
        {
            ToTable("Filmlerin Ödülleri");

            //Coka cok ilişkinin tamamlanması

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.AwardID,
                x.MovieID
            });
        }
    }
}
