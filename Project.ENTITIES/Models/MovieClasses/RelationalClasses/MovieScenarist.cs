using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class MovieScenarist : BaseEntity
    {
        public int MovieID { get; set; }
        public int ScenaristID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Scenarist Scenarist { get; set; }
    }
}
