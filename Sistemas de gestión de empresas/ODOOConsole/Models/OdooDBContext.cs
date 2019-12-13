using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ODOOConsole.Models
{
    public partial class OdooDBContext : DbContext
    {
        public OdooDBContext()
        {
        }

        public OdooDBContext(DbContextOptions<OdooDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IrModuleModule> IrModuleModule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=OdooDB;Username=openpg;Password=openpgpwd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IrModuleModule>(entity =>
            {
                entity.ToTable("ir_module_module");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("ir_module_module_category_id_index");

                entity.HasIndex(e => e.Name)
                    .HasName("ir_module_module_name_index");

                entity.HasIndex(e => e.State)
                    .HasName("ir_module_module_state_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasColumnType("character varying");

                entity.Property(e => e.AutoInstall)
                    .HasColumnName("auto_install")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Contributors)
                    .HasColumnName("contributors")
                    .HasComment("Contributors");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.CreateUid).HasColumnName("create_uid");

                entity.Property(e => e.Demo)
                    .HasColumnName("demo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("character varying");

                entity.Property(e => e.LatestVersion)
                    .HasColumnName("latest_version")
                    .HasColumnType("character varying");

                entity.Property(e => e.License)
                    .HasColumnName("license")
                    .HasMaxLength(32);

                entity.Property(e => e.Maintainer)
                    .HasColumnName("maintainer")
                    .HasColumnType("character varying")
                    .HasComment("Maintainer");

                entity.Property(e => e.MenusByModule)
                    .HasColumnName("menus_by_module")
                    .HasComment("Menus");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PublishedVersion)
                    .HasColumnName("published_version")
                    .HasColumnType("character varying")
                    .HasComment("Published Version");

                entity.Property(e => e.ReportsByModule)
                    .HasColumnName("reports_by_module")
                    .HasComment("Reports");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Shortdesc)
                    .HasColumnName("shortdesc")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(16);

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToBuy)
                    .HasColumnName("to_buy")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying")
                    .HasComment("URL");

                entity.Property(e => e.ViewsByModule)
                    .HasColumnName("views_by_module")
                    .HasComment("Views");

                entity.Property(e => e.Web)
                    .HasColumnName("web")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("character varying");

                entity.Property(e => e.WriteDate).HasColumnName("write_date");

                entity.Property(e => e.WriteUid).HasColumnName("write_uid");
            });

            modelBuilder.HasSequence("base_cache_signaling");

            modelBuilder.HasSequence("base_registry_signaling");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
