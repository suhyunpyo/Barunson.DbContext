using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 초안 수정요청 내용
/// </summary>
public partial class PREVIEW_OPINION
{
    [Key]
    public int BBS_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ORDER_TYPE { get; set; } = null!;

    public int? PREVIEW_SEQ { get; set; }

    public int? SUB_SEQ { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WRITER { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WRITER_IP { get; set; }

    [StringLength(4000)]
    public string? CONTENT { get; set; }

    [StringLength(4000)]
    public string? REPLY { get; set; }

    public int? REF { get; set; }

    public byte? DEPTH { get; set; }

    public int VIEW_CNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(300)]
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
}
