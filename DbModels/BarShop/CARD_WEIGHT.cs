using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// FAQ무게검증기초데이터관련
/// </summary>
public partial class CARD_WEIGHT
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    /// <summary>
    /// 단위무게
    /// </summary>
    [Column("card_weight")]
    public double card_weight1 { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }
}
