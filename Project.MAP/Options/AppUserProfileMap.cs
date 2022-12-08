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
            Property(x => x.Adress).HasColumnName("Adres");
            Property(x => x.CreditCardNo).HasColumnName("Kredi Kartı Numarası");
            Property(x => x.CVV).HasColumnName("CVV Güvenlik Numarası");
            Property(x => x.ExpiryDay).HasColumnName("Son Kullanma gunu");
            Property(x => x.ExpiryMount).HasColumnName("Son Kullanma Ayi");
            Property(x => x.ExpiryYear).HasColumnName("Son Kullanma Yili");
            Property(x => x.PhoneNo).HasColumnName("Telefon Numarası");
            Property(x => x.SubscriptionType).HasColumnName("Abonelik Türü");

        }
    }
}
