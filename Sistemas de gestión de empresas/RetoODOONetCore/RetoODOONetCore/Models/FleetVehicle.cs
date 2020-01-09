using System;
using System.Collections.Generic;

namespace RetoODOONetCore.Models
{
    public partial class FleetVehicle
    {
        public int Id { get; set; }
        public int? MessageMainAttachmentId { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? CompanyId { get; set; }
        public string LicensePlate { get; set; }
        public string VinSn { get; set; }
        public int? DriverId { get; set; }
        public int ModelId { get; set; }
        public int? BrandId { get; set; }
        public DateTime? AcquisitionDate { get; set; }
        public DateTime? FirstContractDate { get; set; }
        public string Color { get; set; }
        public int? StateId { get; set; }
        public string Location { get; set; }
        public int? Seats { get; set; }
        public string ModelYear { get; set; }
        public int? Doors { get; set; }
        public string OdometerUnit { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public int? Horsepower { get; set; }
        public double? HorsepowerTax { get; set; }
        public int? Power { get; set; }
        public double? Co2 { get; set; }
        public double? CarValue { get; set; }
        public double? ResidualValue { get; set; }
        public int? CreateUid { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? WriteUid { get; set; }
        public DateTime? WriteDate { get; set; }
    }
}
