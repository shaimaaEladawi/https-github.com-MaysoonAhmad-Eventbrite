using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using ProductCatalogApi.Domain;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;





//this class is for entity framework instrcutions

namespace ProductCatalogApi.Data

{

    public class CatalogContext : DbContext

    {

        public CatalogContext(DbContextOptions options)

            : base(options)

        {

        }



        public DbSet<CatalogEventType> CatalogEventTypes { get; set; }

        public DbSet<CatalogEventCategory> CatalogEventCategories { get; set; }

        public DbSet<CatalogEventLocation> CatalogEventLocations { get; set; }

        public DbSet<CatalogEventItem> CatalogEventItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<CatalogEventType>(e =>

            {

                e.ToTable("CatalogEventType");



                e.Property(c => c.Id)

                    .IsRequired()

                    .UseHiLo("catalog_type_hilo");



                e.Property(c => c.Type)

                    .IsRequired()

                    .HasMaxLength(100);

            });



            modelBuilder.Entity<CatalogEventCategory>(e =>

            {

                e.ToTable("CatalogEventCategory");

                e.Property(c=> c.Id)

                    .IsRequired()

                    .UseHiLo("catalog_category_hilo");



                e.Property(c => c.Category)

                    .IsRequired()

                    .HasMaxLength(100);

            });


            modelBuilder.Entity<CatalogEventLocation>(e =>

            {

                e.ToTable("CatalogEventLocation");

                e.Property(c => c.Id)

                    .IsRequired()

                    .UseHiLo("catalog_location_hilo");



                e.Property(c => c.Location)

                    .IsRequired()

                    .HasMaxLength(100);

            });



            modelBuilder.Entity<CatalogEventItem>(e =>

            {

                e.ToTable("CatalogEventItem");

                e.Property(c => c.Id)

                    .IsRequired()

                    .UseHiLo("catalog_hilo");



                e.Property(c => c.Name)

                    .IsRequired()

                    .HasMaxLength(5000);



                e.Property(c => c.Schedule)

                    .IsRequired();

                e.Property(c => c.Price)

                    .IsRequired();

                e.Property(c => c.Description)

                   .IsRequired()

                   .HasMaxLength(5000);


                e.Property(c => c.PictureUrl)

                   .IsRequired()

                   .HasMaxLength(100);



                e.HasOne(c => c.CatalogEventCategory)

                    .WithMany()

                    .HasForeignKey(c => c.CatalogCategoryId);



                e.HasOne(c => c.CatalogEventType)

                    .WithMany()

                    .HasForeignKey(c => c.CatalogTypeId);


                e.HasOne(c => c.CatalogEventLocation)

                  .WithMany()

                  .HasForeignKey(c => c.CatalogLocationId);




            });

        }



    }

}