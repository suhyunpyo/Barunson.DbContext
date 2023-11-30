using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드속성 카테고리정보	
/// </summary>
public partial class S2_CardStyleItem
{
    [Key]
    public int CardStyle_Seq { get; set; }

    /// <summary>
    /// 스타일명
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? CardStyle_Num { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CardStyle { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CardStyle_Site { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CardStyle_Category { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? CardStyle_Date { get; set; }
}
