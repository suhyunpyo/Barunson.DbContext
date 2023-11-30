using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class tEventRelationBanner
{
    [Key]
    public long idx { get; set; }

    public int? eventIdx { get; set; }

    public int? bannerGb { get; set; }

    public int ViewLocation { get; set; }

    public int? bannerType { get; set; }

    public int? projectView { get; set; }

    public int? Seq { get; set; }

    public int? r_eventIdx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UseYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PartnerYN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BannerFile { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? BannerLink { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Contents { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDT { get; set; }
}
