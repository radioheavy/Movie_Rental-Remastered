using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class MovieTag : BaseEntity
    {
        public int MovieID { get; set; }
        public int TagID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
