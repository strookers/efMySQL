using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using FjRichter.Models;
using FJRichter.Models;
using MySql.Data.Entity;

namespace FJRichter.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EntityContext : DbContext
    {
        public EntityContext() : base("EntityContext")
        {
        }

        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Content> Contents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }


}