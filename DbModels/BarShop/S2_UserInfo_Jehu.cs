using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("UserId", "PartnerCode")]
[Index("PartnerCode", "RegDate", Name = "IX_S2_UserInfo_Jehu_RegDate")]
[Index("PartnerCode", "WithdrawDate", Name = "IX_S2_UserInfo_Jehu_WidhdrawDate")]
public partial class S2_UserInfo_Jehu
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string PartnerCode { get; set; } = null!;

    public bool Consent { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime UpdateDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? WithdrawDate { get; set; }

    public string? ExtendData { get; set; }
}
