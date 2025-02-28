﻿using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALIH\\SQLEXPRESS;initial Catalog=CarBookDb;integrated Security=true;trustservercertificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>() //Rezervasyon tablosu içerisinde
                .HasOne(x => x.PickUpLocation) //Reservation tablosundaki PickUpLocation'ı al
                .WithMany(y=>y.PickUpReservation) //Aldığın PickUpLocation'ı Location tablosundaki PickUpReservation ile ilişkilendir
                .HasForeignKey(z => z.PickUpLocationID) //Bunu da PickUpLocationID sütunu ile ilişkilendir
                .OnDelete(DeleteBehavior.ClientSetNull); //Silindiğinde de hata vermemesi için null olarak atama sağlayan metod

            modelBuilder.Entity<Reservation>() //Rezervasyon tablosu içerisinde
                .HasOne(x => x.DropOffLocation) //Reservation tablosundaki DropOffLocation'ı al
                .WithMany(y => y.DropOffReservation) //Aldığın DropOffLocation'ı Location tablosundaki DropOffReservation ile ilişkilendir
                .HasForeignKey(z => z.DropOffLocationID) //Bunu da DropOffLocationID sütunu ile ilişkilendir
                .OnDelete(DeleteBehavior.ClientSetNull); //Silindiğinde de hata vermemesi için null olarak atama sağlayan metod
        }
    }
}
