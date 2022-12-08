using Project.ENTITIES;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserProfileMap : BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            ToTable("Profiller");
            Property(x => x.Adress).HasColumnName("Kullanıcı Rolü");
            Property(x => x.CreditCardNo).HasColumnName("Kullanıcı Rolü");
            Property(x => x.CVV).HasColumnName("Kullanıcı Rolü");
            Property(x => x.ExpiryDay).HasColumnName("Kullanıcı Rolü");
            Property(x => x.ExpiryMount).HasColumnName("Kullanıcı Rolü");
            Property(x => x.ExpiryYear).HasColumnName("Kullanıcı Rolü");
            Property(x => x.PhoneNo).HasColumnName("Kullanıcı Rolü");
            Property(x => x.SubscriptionType).HasColumnName("Kullanıcı Rolü");

        }
    }
}
