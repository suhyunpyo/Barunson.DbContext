using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BEWEDDING_CONTENT
{
    [Key]
    public int CONTENT_SEQ { get; set; }

    public int SOURCE_SEQ { get; set; }

    [StringLength(50)]
    public string? CONTENT_TYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? LOGO_DISPLAY_YN { get; set; }

    [StringLength(100)]
    public string? LOGO_TYPE { get; set; }

    [StringLength(20)]
    public string? IMAGE_TAG { get; set; }

    [StringLength(1000)]
    public string? CONTENT_1 { get; set; }

    [StringLength(1000)]
    public string? CONTENT_2 { get; set; }

    [StringLength(1000)]
    public string? CONTENT_3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DEL_YN { get; set; }

    [StringLength(1000)]
    public string? CONTENT_LINK_URL { get; set; }

    public int? CONTENT_CLICK_CNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INTERNAL_LINK_YORN { get; set; }

    public int? SORTING_NUM { get; set; }

    public int? PREVIEW_SORTING_NUM { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(50)]
    public string? UPD_ID { get; set; }
}
