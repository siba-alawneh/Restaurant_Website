using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant_Website.Models;

namespace Restaurant_Website.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public  DbSet<MasterAbout> MasterAbouts { get; set; }

        public  DbSet<MasterCategoryMenu> MasterCategoryMenus { get; set; }

        public  DbSet<MasterContactUsInformation> MasterContactUsInformations { get; set; }

        public  DbSet<MasterItemMenu> MasterItemMenus { get; set; }
        public  DbSet<MasterMenu> MasterMenus { get; set; }

        public  DbSet<MasterOffer> MasterOffers { get; set; }

        public  DbSet<MasterPartner> MasterPartners { get; set; }   
        public  DbSet<MasterService> MasterServices { get; set; }

        public  DbSet<MasterSlider> MasterSliders { get; set; }

        public  DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }
        public  DbSet<MasterWorkingHour> MasterWorkingHours { get; set; }

        public  DbSet<SystemSetting> SystemSettings { get; set; }

        public  DbSet<TransactionBookTable> TransactionBookTables { get; set; }
        public  DbSet<TransactionContactUs> TransactionContactUs { get; set; }

        public  DbSet<TransactionNewsletter> TransactionNewsletters { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //        => optionsBuilder.UseSqlServer("Data Source=SIBA\\SQL2025;Initial Catalog=Restaurant_Last_20260915;User ID=sa;Password=123;Trust Server Certificate=True");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<MasterAbout>(entity =>
        //    {
        //        entity.ToTable("MasterAbout");

        //        entity.Property(e => e.MasterAboutBrief).HasMaxLength(250);
        //        entity.Property(e => e.MasterAboutTitle).HasMaxLength(250);
        //        entity.Property(e => e.MasterAboutUrl).HasDefaultValue("");
        //    });

        //    modelBuilder.Entity<MasterCategoryMenu>(entity =>
        //    {
        //        entity.ToTable("MasterCategoryMenu");

        //        entity.Property(e => e.MasterCategoryMenuName).HasMaxLength(250);
        //    });

        //    modelBuilder.Entity<MasterContactUsInformation>(entity =>
        //    {
        //        entity.ToTable("MasterContactUsInformation");

        //        entity.Property(e => e.MasterContactUsInformationIcon).HasDefaultValue("");
        //    });

        //    modelBuilder.Entity<MasterItemMenu>(entity =>
        //    {
        //        entity.ToTable("MasterItemMenu");

        //        entity.HasIndex(e => e.MasterCategoryMenuId, "IX_MasterItemMenu_MasterCategoryMenuId");

        //        entity.Property(e => e.MasterItemMenuPrice).HasColumnType("decimal(18, 2)");

        //        entity.HasOne(d => d.MasterCategoryMenu).WithMany(p => p.MasterItemMenus).HasForeignKey(d => d.MasterCategoryMenuId);
        //    });

        //    modelBuilder.Entity<MasterMenu>(entity =>
        //    {
        //        entity.ToTable("MasterMenu");

        //        entity.Property(e => e.MasterMenuName).HasMaxLength(250);
        //    });

        //    modelBuilder.Entity<MasterOffer>(entity =>
        //    {
        //        entity.ToTable("MasterOffer");
        //    });

        //    modelBuilder.Entity<MasterPartner>(entity =>
        //    {
        //        entity.ToTable("MasterPartner");
        //    });

        //    modelBuilder.Entity<MasterService>(entity =>
        //    {
        //        entity.ToTable("MasterService");

        //        entity.Property(e => e.MasterServiceIcon).HasDefaultValue("");
        //    });

        //    modelBuilder.Entity<MasterSlider>(entity =>
        //    {
        //        entity.ToTable("MasterSlider");
        //    });

        //    modelBuilder.Entity<MasterSocialMedium>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);

        //        entity.Property(e => e.MasterSocialMediaIcon).HasDefaultValue("");
        //    });

        //    modelBuilder.Entity<MasterWorkingHour>(entity =>
        //    {
        //        entity.ToTable("MasterWorkingHour");
        //    });

        //    modelBuilder.Entity<SystemSetting>(entity =>
        //    {
        //        entity.ToTable("SystemSetting");
        //    });

        //    modelBuilder.Entity<TransactionBookTable>(entity =>
        //    {
        //        entity.ToTable("TransactionBookTable");
        //    });

        //    modelBuilder.Entity<TransactionContactU>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //    });

        //    modelBuilder.Entity<TransactionNewsletter>(entity =>
        //    {
        //        entity.ToTable("TransactionNewsletter");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
