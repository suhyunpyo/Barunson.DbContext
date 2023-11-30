using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 빠른손 공지
/// </summary>
[Keyless]
public partial class bbarunson_notice
{
    public int UpdateSeq { get; set; }

    public int ItemNo { get; set; }

    /// <summary>
    /// 공지일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime UpdateDT { get; set; }

    /// <summary>
    /// 공시사항
    /// </summary>
    [Column(TypeName = "text")]
    public string? UpdateContent { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UseYN { get; set; }
}
