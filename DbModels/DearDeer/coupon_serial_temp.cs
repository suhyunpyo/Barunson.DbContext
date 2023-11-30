using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[Index("coupon_direct", Name = "coupon_direct", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class coupon_serial_temp
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int coupon_id { get; set; }

    /// <summary>
    /// 임시쿠폰
    /// </summary>
    [StringLength(20)]
    public string coupon_direct { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
