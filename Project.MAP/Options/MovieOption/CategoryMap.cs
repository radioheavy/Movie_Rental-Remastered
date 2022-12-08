using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategoriler");
            Property(x => x.CategoryName).HasColumnName("Kategori Ismi");
            Property(x => x.Description).HasColumnName("Aciklama");
        }
    }
}
