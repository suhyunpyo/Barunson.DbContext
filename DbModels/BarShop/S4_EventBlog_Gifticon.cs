using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_EventBlog_Gifticon
{
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    public string uname { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? blog_url { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? cafe_url { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string gifticon_type { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string hphone1 { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string hphone2 { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string hphone3 { get; set; } = null!;

    [StringLength(200)]
    public string? msg { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isSms { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? sms_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
