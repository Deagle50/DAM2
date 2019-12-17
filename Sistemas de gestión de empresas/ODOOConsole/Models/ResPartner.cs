using System;
using System.Collections.Generic;

namespace ODOOConsole.Models
{
    public partial class ResPartner
    {
        public ResPartner()
        {
            InverseCommercialPartner = new HashSet<ResPartner>();
            InverseParent = new HashSet<ResPartner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string DisplayName { get; set; }
        public DateTime? Date { get; set; }
        public int? Title { get; set; }
        public int? ParentId { get; set; }
        public string Ref { get; set; }
        public string Lang { get; set; }
        public string Tz { get; set; }
        public int? UserId { get; set; }
        public string Vat { get; set; }
        public string Website { get; set; }
        public string Comment { get; set; }
        public double? CreditLimit { get; set; }
        public string Barcode { get; set; }
        public bool? Active { get; set; }
        public bool? Customer { get; set; }
        public bool? Supplier { get; set; }
        public bool? Employee { get; set; }
        public string Function { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public bool? IsCompany { get; set; }
        public int? IndustryId { get; set; }
        public int? Color { get; set; }
        public bool? PartnerShare { get; set; }
        public int? CommercialPartnerId { get; set; }
        public string CommercialCompanyName { get; set; }
        public string CompanyName { get; set; }
        public int? CreateUid { get; set; }
        public int? WriteUid { get; set; }
        public DateTime? WriteDate { get; set; }
        public int? MessageMainAttachmentId { get; set; }
        public int? MessageBounce { get; set; }
        public string SignupToken { get; set; }
        public string SignupType { get; set; }
        public DateTime? SignupExpiration { get; set; }
        public DateTime? CalendarLastNotifAck { get; set; }
        public int? PartnerGid { get; set; }
        public string AdditionalInfo { get; set; }
        public int? TeamId { get; set; }

        public virtual ResPartner CommercialPartner { get; set; }
        public virtual ResPartner Parent { get; set; }
        public virtual ICollection<ResPartner> InverseCommercialPartner { get; set; }
        public virtual ICollection<ResPartner> InverseParent { get; set; }
    }
}
