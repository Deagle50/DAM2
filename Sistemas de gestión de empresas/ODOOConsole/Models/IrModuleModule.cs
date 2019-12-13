using System;
using System.Collections.Generic;

namespace ODOOConsole.Models
{
    public partial class IrModuleModule
    {
        public int Id { get; set; }
        public int? CreateUid { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public int? WriteUid { get; set; }
        public string Website { get; set; }
        public string Summary { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Icon { get; set; }
        public string State { get; set; }
        public string LatestVersion { get; set; }
        public string Shortdesc { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public bool? Application { get; set; }
        public bool? Demo { get; set; }
        public bool? Web { get; set; }
        public string License { get; set; }
        public int? Sequence { get; set; }
        public bool? AutoInstall { get; set; }
        public bool? ToBuy { get; set; }
        public string Maintainer { get; set; }
        public string Contributors { get; set; }
        public string PublishedVersion { get; set; }
        public string Url { get; set; }
        public string MenusByModule { get; set; }
        public string ReportsByModule { get; set; }
        public string ViewsByModule { get; set; }
    }
}
