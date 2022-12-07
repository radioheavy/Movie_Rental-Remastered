using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class MovieAward : BaseEntity
    {
        public int MovieID { get; set; }
        public int AwardID { get; set; }


        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Award Award { get; set; }
    }
}
