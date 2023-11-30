using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_opinion
{
    public int BBS_SEQ { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WRITER { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WRITER_IP { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CONTENT { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? REPLY { get; set; }

    public int VIEW_CNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FILE_PATH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string STATUS { get; set; } = null!;

    public int ORDER_SEQ { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NOTIFY_EMAIL_YESORNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? upfile { get; set; }
}
