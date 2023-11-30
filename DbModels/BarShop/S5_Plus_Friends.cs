using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이벤트 더카드 친구소개
/// </summary>
public partial class S5_Plus_Friends
{
    [Key]
    public int PF_Idx { get; set; }

    [StringLength(50)]
    public string? PF_UID { get; set; }

    [StringLength(50)]
    public string? PF_FUID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PF_Regdate { get; set; }

    public int? PF_Status { get; set; }

    [StringLength(1)]
    public string? PF_Coupon_Status { get; set; }

    [StringLength(1)]
    public string? PF_Coupon_Status_F { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }
}
