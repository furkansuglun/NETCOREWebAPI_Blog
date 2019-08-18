using Microsoft.EntityFrameworkCore;
using NETCoreWebAPI_Blog_DB.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        //public DbSet<Article> Article { get; set; }
        //public DbSet<Member> Member { get; set; }
        //public DbSet<Label> Label { get; set; }
        //public DbSet<Comment> Comment { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
        {

        }

        public BlogContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-FCSP285\SQLEXPRESS;Database=NETCoreWebAPI_Blog;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>(entity =>
            //{
            //    entity.Property(e => e.Id)
            //    .HasColumnName("Id")
            //    .ValueGeneratedNever();

            //    entity.Property(e => e.Name)
            //    .IsRequired()
            //    .HasColumnType("varchar(150)");
            //});

            //modelBuilder.Entity<Article>()
            //    .HasMany(c => c.Members)
            //    .WithOne(e => e.Article);

            //modelBuilder.Entity<Article>()
            //   .HasMany(c => c.Labels)
            //   .WithOne(e => e.Article);

            //modelBuilder.Entity<Article>()
            //   .HasMany(c => c.Categories)
            //   .WithOne(e => e.Article);

            //modelBuilder.Entity<Article>()
            //  .HasMany(c => c.Comments)
            //  .WithOne(e => e.Article); 

            //modelBuilder.Entity<Member>()
            //  .HasMany(c => c.Comments)
            //  .WithOne(e => e.Member);

        }
    }
}
