using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieActorMap : BaseMap<MovieActor>
    {
        public MovieActorMap()
        {
            ToTable("Oyuncularin Filmleri");

            //Coka cok ilişkinin tamamlanması

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ActorID,
                x.MovieID
            });
        }
    }
}