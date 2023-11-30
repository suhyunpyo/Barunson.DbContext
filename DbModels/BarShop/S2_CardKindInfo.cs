using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드종류정보
/// </summary>
public partial class S2_CardKindInfo
{
    /// <summary>
    /// 주문타입
    /// </summary>
    [Key]
    public int CardKind_Seq { get; set; }

    /// <summary>
    /// 주문타입설명
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? CardKind { get; set; }
}
