using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Premier_Movie
{
    public int seq { get; set; }

    [Key]
    public int order_seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(200)]
    public string? qrcode_image { get; set; }

    [StringLength(200)]
    public string? movie_url { get; set; }

    [StringLength(500)]
    public string? etc_comment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isComplete { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }
}
