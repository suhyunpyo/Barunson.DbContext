using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 혼수폐쇄몰 회원이동 history Log
/// </summary>
[Keyless]
[Index("uid", Name = "idx_barunToclosed_history_log_01")]
public partial class barunToclosed_history_log
{
    /// <summary>
    /// 회원아이디
    /// </summary>
    [StringLength(50)]
    public string uid { get; set; } = null!;

    /// <summary>
    /// 방문시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? linked_tmstmp { get; set; }
}
