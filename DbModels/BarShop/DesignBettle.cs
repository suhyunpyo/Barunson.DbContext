using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 디자인배틀이벤트
/// </summary>
public partial class DesignBettle
{
    [Key]
    public int SEQ { get; set; }

    /// <summary>
    /// 배틀 회차
    /// </summary>
    public short Num { get; set; }

    /// <summary>
    /// 1: 별디자인, 2:달디자인
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Gubun { get; set; } = null!;

    public int Card_Seq { get; set; }

    [Column(TypeName = "text")]
    public string Content { get; set; } = null!;

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Member_id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Order_Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Order_Email { get; set; }
}
