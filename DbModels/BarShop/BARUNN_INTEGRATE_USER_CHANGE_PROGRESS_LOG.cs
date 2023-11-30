using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 전환 진행중 상태  로그
/// </summary>
[Index("ID", Name = "IX_INTEGRATE_ID")]
public partial class BARUNN_INTEGRATE_USER_CHANGE_PROGRESS_LOG
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DUPINFO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STEP { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? STEP_DESC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
