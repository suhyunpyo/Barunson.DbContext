using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S5_Plus_Friends_UID
{
    [Key]
    public int P_Idx { get; set; }

    [StringLength(50)]
    public string P_UID { get; set; } = null!;

    [StringLength(1)]
    public string? P_Coupon_Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime P_Regdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? P_Coupon_Regdate { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }
}
