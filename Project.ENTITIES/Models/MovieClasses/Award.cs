using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class Award : BaseEntity
    {
        public string AwardName { get; set; }
        public string AwardDate { get; set; }


        //Relational Properties
        public virtual List<Movie> Movies { get; set; }
    }
}
