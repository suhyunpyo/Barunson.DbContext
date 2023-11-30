using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("event_num", "seq")]
public partial class S4_PhotoStory
{
    [Key]
    public int event_num { get; set; }

    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? addr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr2 { get; set; }

    public int? zipcode { get; set; }

    public string? comment { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? image_url { get; set; }

    public int? img_width { get; set; }

    public int? img_height { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? url { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isVisible { get; set; }

    public int cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MOD_DATE { get; set; }

    public int? UP_CNT { get; set; }
}
