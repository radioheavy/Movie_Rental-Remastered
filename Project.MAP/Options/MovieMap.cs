using Project.ENTITIES.Models;
using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieMap : BaseMap<Movie>
    {
        public MovieMap()
        {
            ToTable("Filmler");
            Property(x => x.MovieName).HasColumnName("Film Ismi");
            Property(x => x.MovieReview).HasColumnName("Özeti");
            Property(x => x.Movie_Specification).HasColumnName("Özellikleri");
            Property(x => x.Movie_Release_Date).HasColumnName("Yayin Tarihi");
            Property(x => x.Audio_Feature).HasColumnName("Ses Özellikleri");
            Property(x => x.Subtitle).HasColumnName("Altyazi Durumu");
            Property(x => x.MovieTrailer).HasColumnName("Fragman");
            Property(x => x.Supplier).HasColumnName("Tedarikci Firma");
            Property(x => x.AwardWon).HasColumnName("Kazanilan Ödüller");
            Property(x => x.UnitsInStock).HasColumnName("Stok Durumu");
            Property(x => x.UnitPrice).HasColumnName("Fiyati").HasColumnType("money");
            Property(x => x.ImagePath).HasColumnName("Afis");
            Property(x => x.VideoPath).HasColumnName("Fragman");


        }
    }
}