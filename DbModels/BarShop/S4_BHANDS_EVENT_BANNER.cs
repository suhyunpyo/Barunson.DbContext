using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_BHANDS_EVENT_BANNER
{
    public int SEQ { get; set; }

    public int MD_SEQ { get; set; }

    public int SORTING_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MD_TITLE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SUB_TITLE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LINK_URL { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IMGFILE_PATH { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? BACKGROUND_COLOR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EVENT_OPEN_YORN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LINK_TARGET { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string VIEW_DIV { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string JEHU_VIEW_DIV { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? WING_BANNER_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BAND_BANNER_YN { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string CREATE_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CREATE_DATE { get; set; }
}
