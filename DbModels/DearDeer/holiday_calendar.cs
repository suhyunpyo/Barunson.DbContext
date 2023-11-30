using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 휴일관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class holiday_calendar
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 휴일
    /// </summary>
    public DateOnly? holiday { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(255)]
    public string? holiday_desc { get; set; }
}
