using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ODOOConsole.Models;

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
        public virtual DbSet<ResPartner> ResPartner { get; set; }

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

            modelBuilder.Entity<ResPartner>(entity =>
            {
                entity.ToTable("res_partner");

                entity.HasIndex(e => e.CommercialPartnerId)
                    .HasName("res_partner_commercial_partner_id_index");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("res_partner_company_id_index");

                entity.HasIndex(e => e.Date)
                    .HasName("res_partner_date_index");

                entity.HasIndex(e => e.DisplayName)
                    .HasName("res_partner_display_name_index");

                entity.HasIndex(e => e.MessageMainAttachmentId)
                    .HasName("res_partner_message_main_attachment_id_index");

                entity.HasIndex(e => e.Name)
                    .HasName("res_partner_name_index");

                entity.HasIndex(e => e.ParentId)
                    .HasName("res_partner_parent_id_index");

                entity.HasIndex(e => e.Ref)
                    .HasName("res_partner_ref_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasComment("Active");

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additional_info")
                    .HasColumnType("character varying")
                    .HasComment("Additional info");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasColumnType("character varying")
                    .HasComment("Barcode");

                entity.Property(e => e.CalendarLastNotifAck)
                    .HasColumnName("calendar_last_notif_ack")
                    .HasComment("Last notification marked as read from base Calendar");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying")
                    .HasComment("City");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasComment("Color Index");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasComment("Notes");

                entity.Property(e => e.CommercialCompanyName)
                    .HasColumnName("commercial_company_name")
                    .HasColumnType("character varying")
                    .HasComment("Company Name Entity");

                entity.Property(e => e.CommercialPartnerId)
                    .HasColumnName("commercial_partner_id")
                    .HasComment("Commercial Entity");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasColumnType("character varying")
                    .HasComment("Company Name");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasComment("Country");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.CreateUid)
                    .HasColumnName("create_uid")
                    .HasComment("Created by");

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("credit_limit")
                    .HasComment("Credit Limit");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasComment("Is a Customer");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasComment("Date");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("display_name")
                    .HasColumnType("character varying")
                    .HasComment("Display Name");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("character varying")
                    .HasComment("Email");

                entity.Property(e => e.Employee)
                    .HasColumnName("employee")
                    .HasComment("Employee");

                entity.Property(e => e.Function)
                    .HasColumnName("function")
                    .HasColumnType("character varying")
                    .HasComment("Job Position");

                entity.Property(e => e.IndustryId)
                    .HasColumnName("industry_id")
                    .HasComment("Industry");

                entity.Property(e => e.IsCompany)
                    .HasColumnName("is_company")
                    .HasComment("Is a Company");

                entity.Property(e => e.Lang)
                    .HasColumnName("lang")
                    .HasColumnType("character varying")
                    .HasComment("Language");

                entity.Property(e => e.MessageBounce)
                    .HasColumnName("message_bounce")
                    .HasComment("Bounce");

                entity.Property(e => e.MessageMainAttachmentId)
                    .HasColumnName("message_main_attachment_id")
                    .HasComment("Main Attachment");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("character varying")
                    .HasComment("Mobile");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasComment("Related Company");

                entity.Property(e => e.PartnerGid)
                    .HasColumnName("partner_gid")
                    .HasComment("Company database ID");

                entity.Property(e => e.PartnerShare)
                    .HasColumnName("partner_share")
                    .HasComment("Share Partner");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("character varying")
                    .HasComment("Phone");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasColumnType("character varying")
                    .HasComment("Internal Reference");

                entity.Property(e => e.SignupExpiration)
                    .HasColumnName("signup_expiration")
                    .HasComment("Signup Expiration");

                entity.Property(e => e.SignupToken)
                    .HasColumnName("signup_token")
                    .HasColumnType("character varying")
                    .HasComment("Signup Token");

                entity.Property(e => e.SignupType)
                    .HasColumnName("signup_type")
                    .HasColumnType("character varying")
                    .HasComment("Signup Token Type");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .HasComment("State");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("character varying")
                    .HasComment("Street");

                entity.Property(e => e.Street2)
                    .HasColumnName("street2")
                    .HasColumnType("character varying")
                    .HasComment("Street2");

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasComment("Is a Vendor");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasComment("Sales Team");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasComment("Title");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("character varying")
                    .HasComment("Address Type");

                entity.Property(e => e.Tz)
                    .HasColumnName("tz")
                    .HasColumnType("character varying")
                    .HasComment("Timezone");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("Salesperson");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("character varying")
                    .HasComment("Tax ID");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("character varying")
                    .HasComment("Website");

                entity.Property(e => e.WriteDate)
                    .HasColumnName("write_date")
                    .HasComment("Last Updated on");

                entity.Property(e => e.WriteUid)
                    .HasColumnName("write_uid")
                    .HasComment("Last Updated by");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("character varying")
                    .HasComment("Zip");

                entity.HasOne(d => d.CommercialPartner)
                    .WithMany(p => p.InverseCommercialPartner)
                    .HasForeignKey(d => d.CommercialPartnerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("res_partner_commercial_partner_id_fkey");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("res_partner_parent_id_fkey");
            });

            modelBuilder.HasSequence("base_cache_signaling");

            modelBuilder.HasSequence("base_registry_signaling");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
