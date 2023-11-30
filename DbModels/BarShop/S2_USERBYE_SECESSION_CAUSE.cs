using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 탈퇴 사유
/// </summary>
public partial class S2_USERBYE_SECESSION_CAUSE
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DUP_INFO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SITE_DIV { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? SECESSION_CAUSE_CODE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ETC_COMMENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
