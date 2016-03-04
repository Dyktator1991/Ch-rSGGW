using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models;
using ChoirSGGW.Entities.Models.Types;

namespace ChoirSGGW.DataAccess.Context
{
    public class ChoirContext : DbContext
    {
        public ChoirContext() : base("name=ChoirSGGW_DB_ConnectionString")
        {
            Database.SetInitializer<ChoirContext>(new CreateDatabaseIfNotExists<ChoirContext>());
        }

        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Repertoire> Repertoire { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<SongNote> SongNote { get; set; }
        public DbSet<Topicality> Topicality { get; set; }

        //Types
        public DbSet<ClotheTypes> ClotheType { get; set; }
        public DbSet<SongsType> SongsTypes { get; set; }
        public DbSet<TopicalityType> TopicalityType { get; set; }
        public DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //AddToClothes();
            //AddSongs();
        }

        //void AddToClothes()
        //{
        //    ClotheType.Add(new ClotheTypes("Galowy"));
        //    ClotheType.Add(new ClotheTypes("Dowolny"));
        //}

        //void AddSongs()
        //{
        //    ClotheType.Add(new ClotheTypes("Kolęda"));
        //}
    }
}
