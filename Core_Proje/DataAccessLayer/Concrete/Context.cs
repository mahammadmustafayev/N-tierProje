﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseSqlServer("Server=localhost;Database=CoreProject;uid=sa;pwd=247Pro!!;TrustServerCertificate=true;");
    }


    public DbSet<Feature> Features { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}
