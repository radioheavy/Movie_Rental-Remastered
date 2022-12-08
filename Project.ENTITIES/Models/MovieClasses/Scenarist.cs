using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.MovieClasses
{
    public class Scenarist : BaseEntity
    {


        //Relational Properties
        public virtual List<Movie> Movies { get; set; }
    }
}
