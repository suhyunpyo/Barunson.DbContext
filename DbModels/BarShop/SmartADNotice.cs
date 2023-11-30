using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 공지사항
/// </summary>
public partial class SmartADNotice
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string writer { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string contents { get; set; } = null!;

    public int? viewcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? notice_div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? end_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string display_YN { get; set; } = null!;
}
