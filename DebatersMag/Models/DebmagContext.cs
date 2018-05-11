using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DebatersMag.Models
{
    public partial class DebmagContext : DbContext
    {
        public virtual DbSet<Debates> Debates { get; set; }
        public virtual DbSet<Magazine> Magazine { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Events> Events { get; set; }

        public DebmagContext(DbContextOptions<DebmagContext> abc) : base(abc)
        {

        }
        // Unable to generate entity type for table 'dbo.Voting'. Please see the warning messages.

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              if (!optionsBuilder.IsConfigured)
              {
  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                  optionsBuilder.UseSqlServer(@"Server=FRASATQUDSIA\SQLEXPRESS;Database=Debmag;Trusted_Connection=True; User ID=sa; Password=fra1997sat;");
              }
          }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Debates>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.DebateLink).HasColumnName("debate link");

                entity.Property(e => e.Topic).HasColumnName("topic");

                entity.Property(e => e.UserName)
                    .HasColumnName("[user name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Magazine>(entity =>
            {
                entity.HasKey(e => e.ArticeiId);

                entity.Property(e => e.ArticeiId).HasColumnName("articei id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasColumnName("phone no");

                entity.Property(e => e.SentArticle).HasColumnName("sent article");

                entity.Property(e => e.SentDate)
                    .HasColumnName("sent date")
                    .HasColumnType("date");

                entity.Property(e => e.UserName)
                    .HasColumnName("User name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfirmPassword)
                    .HasColumnName("confirm password")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first name")
                    .HasMaxLength(50);

                entity.Property(e => e.Interests)
                    .HasColumnName("interests")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("last name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.phone).HasColumnName("phone");

                entity.Property(e => e.RecoveryEmail)
                    .HasColumnName("recovery email")
                    .HasMaxLength(50);
            });
            modelBuilder.Entity<Events>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasColumnName("Color")
                    .HasMaxLength(50);

                entity.Property(e => e.End)
                    .HasColumnName("End")
                    .HasColumnType("DateTime");

                entity.Property(e => e.Start)
                    .HasColumnName("Start")
                    .HasColumnType("DateTime");

                entity.Property(e => e.Text)
                    .HasColumnName("Text")
                    .HasMaxLength(50);


            });

        }
    }

}