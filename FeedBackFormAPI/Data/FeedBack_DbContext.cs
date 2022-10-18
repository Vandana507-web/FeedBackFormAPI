using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FeedBackForm.Models;

namespace FeedBackForm.Data
{
    public partial class FeedBack_DbContext : DbContext
    {
        public FeedBack_DbContext()
        {
        }

        public FeedBack_DbContext(DbContextOptions<FeedBack_DbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback", "matrixlab");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql( "nextval('matrixlab.feedback_id_seq'::regclass)" );

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Phoneno).HasColumnName("phoneno");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
                    
            });


          

            modelBuilder.HasSequence("feedback_id_seq", "matrixlab").StartsAt(100)
                    .IncrementsBy(1);

          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
