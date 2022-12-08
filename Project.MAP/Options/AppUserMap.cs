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
    public class AppUserMap : BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanicilar");
            Property(x => x.UserName).HasColumnName("Kullanici Adi");
            Property(x => x.Password).HasColumnName("Sifre");
            Property(x => x.Email).HasColumnName("Mail Adresi");
            Property(x => x.ActivationCode).HasColumnName("Aktivasyon Kodu");
            Property(x => x.Active).HasColumnName("Aktiflik Durumu");
            Property(x => x.Role).HasColumnName("Kullanici Rolü");


            //birebir ilişkinin tamamlanması

            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}