using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BEWEDDING_NAVIGATION
{
    [Key]
    public int NAVIGATION_SEQ { get; set; }

    [StringLength(100)]
    public string? SITE_NAME { get; set; }

    [StringLength(100)]
    public string? MAIN_TITLE { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? URL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? IMAGE_URL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BACKGROUND_IMAGE_URL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INTERNAL_LINK_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISPLAY_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELETE_YORN { get; set; }

    public int? SORT_NUM { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }
}
