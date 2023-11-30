using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 3자 마케팅동의 로그
/// </summary>
[Index("UID", Name = "IX_S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT_UID")]
[Index("UID", "MARKETING_TYPE_CODE", Name = "IX_S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT_UID_TYPE_CODE")]
public partial class S2_USERINFO_THIRD_PARTY_MARKETING_AGREEMENT
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? MARKETING_TYPE_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
