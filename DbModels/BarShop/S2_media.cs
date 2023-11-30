using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_media
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? writer { get; set; }

    public int? company_seq { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Thumbnail_url { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(2500)]
    [Unicode(false)]
    public string? summary { get; set; }

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isdp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? temp1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? temp2 { get; set; }
}
