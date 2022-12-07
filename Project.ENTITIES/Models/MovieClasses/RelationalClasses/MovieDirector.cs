using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class MovieDirector : BaseEntity
    {
        public int MovieID { get; set; }
        public int DirectorID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Director Director { get; set; }
    }
}
