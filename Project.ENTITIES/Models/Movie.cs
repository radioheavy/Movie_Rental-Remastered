using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }
        public string MovieReview { get; set; }
        public string Movie_Specification { get; set; }
        public string Movie_Release_Date { get; set; }
        public string Audio_Feature { get; set; }
        public string Subtitle { get; set; }
        public string MovieTrailer { get; set; }
        public string AwardWon { get; set; }
        public string Supplier { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public string VideoPath { get; set; }
        public string VideoUrl { get; set; }

        //Relational Properties

        public virtual List<MovieActor> MovieActors { get; set; }
        public virtual List<MovieCategory> MovieCategories { get; set; }
        public virtual List<MovieDirector> MovieDirectors { get; set; }
        public virtual List<MovieScenarist> MovieScenarists { get; set; }
        public virtual List<MovieTag> MovieTags { get; set; }
        public virtual List<MovieAward> MovieAwards { get; set; }
    }
}