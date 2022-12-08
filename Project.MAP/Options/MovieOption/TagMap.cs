using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class TagMap : BaseMap<Tag>
    {
        public TagMap()
        {

            ToTable("Etiketler");
            Property(x => x.TagName).HasColumnName("Afis");

        }
    }
}
