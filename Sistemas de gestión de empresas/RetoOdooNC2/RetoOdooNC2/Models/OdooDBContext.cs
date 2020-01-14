using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RetoOdooNC2.Models
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

        public virtual DbSet<FleetVehicle> FleetVehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=OdooDB;Username=openpg;Password=openpgpwd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<FleetVehicle>(entity =>
            {
                entity.ToTable("fleet_vehicle");

                entity.ForNpgsqlHasComment("Vehicle");

                entity.HasIndex(e => e.MessageMainAttachmentId)
                    .HasName("fleet_vehicle_message_main_attachment_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcquisitionDate)
                    .HasColumnName("acquisition_date")
                    .HasColumnType("date")
                    .ForNpgsqlHasComment("Immatriculation Date");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .ForNpgsqlHasComment("Active");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .ForNpgsqlHasComment("Brand");

                entity.Property(e => e.CarValue)
                    .HasColumnName("car_value")
                    .ForNpgsqlHasComment("Catalog Value (VAT Incl.)");

                entity.Property(e => e.Co2)
                    .HasColumnName("co2")
                    .ForNpgsqlHasComment("CO2 Emissions");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Color");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .ForNpgsqlHasComment("Company");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .ForNpgsqlHasComment("Created on");

                entity.Property(e => e.CreateUid)
                    .HasColumnName("create_uid")
                    .ForNpgsqlHasComment("Created by");

                entity.Property(e => e.Doors)
                    .HasColumnName("doors")
                    .ForNpgsqlHasComment("Doors Number");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driver_id")
                    .ForNpgsqlHasComment("Driver");

                entity.Property(e => e.FirstContractDate)
                    .HasColumnName("first_contract_date")
                    .HasColumnType("date")
                    .ForNpgsqlHasComment("First Contract Date");

                entity.Property(e => e.FuelType)
                    .HasColumnName("fuel_type")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Fuel Type");

                entity.Property(e => e.Horsepower)
                    .HasColumnName("horsepower")
                    .ForNpgsqlHasComment("Horsepower");

                entity.Property(e => e.HorsepowerTax)
                    .HasColumnName("horsepower_tax")
                    .ForNpgsqlHasComment("Horsepower Taxation");

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("license_plate")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("License Plate");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Location");

                entity.Property(e => e.MessageMainAttachmentId)
                    .HasColumnName("message_main_attachment_id")
                    .ForNpgsqlHasComment("Main Attachment");

                entity.Property(e => e.ModelId)
                    .HasColumnName("model_id")
                    .ForNpgsqlHasComment("Model");

                entity.Property(e => e.ModelYear)
                    .HasColumnName("model_year")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Model Year");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Name");

                entity.Property(e => e.OdometerUnit)
                    .IsRequired()
                    .HasColumnName("odometer_unit")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Odometer Unit");

                entity.Property(e => e.Power)
                    .HasColumnName("power")
                    .ForNpgsqlHasComment("Power");

                entity.Property(e => e.ResidualValue)
                    .HasColumnName("residual_value")
                    .ForNpgsqlHasComment("Residual Value");

                entity.Property(e => e.Seats)
                    .HasColumnName("seats")
                    .ForNpgsqlHasComment("Seats Number");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .ForNpgsqlHasComment("State");

                entity.Property(e => e.Transmission)
                    .HasColumnName("transmission")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Transmission");

                entity.Property(e => e.VinSn)
                    .HasColumnName("vin_sn")
                    .HasColumnType("varchar")
                    .ForNpgsqlHasComment("Chassis Number");

                entity.Property(e => e.WriteDate)
                    .HasColumnName("write_date")
                    .ForNpgsqlHasComment("Last Updated on");

                entity.Property(e => e.WriteUid)
                    .HasColumnName("write_uid")
                    .ForNpgsqlHasComment("Last Updated by");
            });
        }
    }
}
