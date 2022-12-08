﻿using Bogus.DataSets;
using Project.COMMON.Tools;
using Project.DAL.Context;
using Project.ENTITIES;
using Project.ENTITIES.Models;
using Project.ENTITIES.Models.MovieClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region Admin

            AppUser au = new AppUser();
            au.UserName = "cgr";
            au.Password = DantexCrypt.Crypt("123");
            au.Email = "cagri.yolyapar@gmail.com";
            au.Role = ENTITIES.Enums.UserRole.Admin;
            au.Active = true;
            context.AppUsers.Add(au);
            context.SaveChanges();

            #endregion

            #region NormalUsers
            for (int i = 0; i < 10; i++)
            {
                AppUser ap = new AppUser();

                ap.UserName = new Internet("tr").UserName();
                ap.Password = new Internet("tr").Password();
                ap.Email = new Internet("tr").Email();

                context.AppUsers.Add(ap);
            }

            context.SaveChanges();

            for (int i = 2; i < 12; i++)
            {
                AppUserProfile apu = new AppUserProfile();
                apu.ID = i; //Birebir ilişki oldugundan dolayı üst tarafta olusturulan AppUser'ların ID'leri ile buraları eşleşmeli...O yüzden döngünün iterasyonunu 2'den baslattık...
                apu.FirstName = new Name("tr").FirstName();
                apu.LastName = new Name("tr").LastName();
                context.AppUserProfiles.Add(apu);
            }
            context.SaveChanges();
            #endregion

            #region KategoriVeUrunBilgileri

            //TODO: Random kategori ve Açıklama/ Ürün ismi eklemek için bir seed metodudur.
            for (int i = 0; i < 10; i++)
            {
                Category c = new Category();
                c.CategoryName = new Commerce("tr").Categories(1)[0];
                c.Description = new Lorem("tr").Sentence(10);

                for (int j = 0; j < 30; j++)
                {
                    Movie p = new Movie();
                    p.MovieName = new Commerce("tr").ProductName();
                    p.UnitPrice = Convert.ToDecimal(new Commerce("tr").Price());
                    p.UnitsInStock = 100;
                    p.ImagePath = new Images().Nightlife();
                    c.Movies.Add(p);
                }
                context.Categories.Add(c);
                context.SaveChanges();
            }

            #endregion

        }
    }
}
