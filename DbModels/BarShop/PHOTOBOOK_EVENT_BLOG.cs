using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_EVENT_BLOG
{
    [Key]
    public int seq { get; set; }

    public int order_id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? writer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string link_url { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isview { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isbest { get; set; } = null!;

    /// <summary>
    /// 0:확인중, 1:지급완료, 2:지급불가
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string iscoupon { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
