using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_MD_Choice_UseCoupon
{
    [Key]
    public int seq { get; set; }

    public int choice_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    public int? view_coupon_downcnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? down_start_dt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? down_end_dt { get; set; }
}
