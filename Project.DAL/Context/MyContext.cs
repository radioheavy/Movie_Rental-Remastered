using Project.DAL.StrategyPattern;
using Project.ENTITIES;
using Project.ENTITIES.Models;
using Project.ENTITIES.Models.MovieClasses;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new AwardMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new DirectorMap());
            modelBuilder.Configurations.Add(new ScenaristMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new MovieActorMap());
            modelBuilder.Configurations.Add(new MovieAwardMap());
            modelBuilder.Configurations.Add(new MovieCategoryMap());
            modelBuilder.Configurations.Add(new MovieDirectorMap());
            modelBuilder.Configurations.Add(new MovieScenaristMap());
            modelBuilder.Configurations.Add(new MovieTagMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Scenarist> Scenarists { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieAward> MovieAwards { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieScenarist> MovieScenarists { get; set; }
        public DbSet<MovieTag> MovieTags { get; set; }
    }
}
