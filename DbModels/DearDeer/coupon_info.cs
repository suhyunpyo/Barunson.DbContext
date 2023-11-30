using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class coupon_info
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(1)]
    public string use_coupon { get; set; } = null!;

    [StringLength(1)]
    public string allow_scope { get; set; } = null!;

    [StringLength(1)]
    public string allow_diposit { get; set; } = null!;

    [StringLength(1)]
    public string allow_discount { get; set; } = null!;

    [StringLength(1)]
    public string restore_before_pay { get; set; } = null!;

    [StringLength(1)]
    public string restore_after_pay { get; set; } = null!;

    [StringLength(1)]
    public string restore_return { get; set; } = null!;

    [StringLength(1)]
    public string restore_exchange { get; set; } = null!;
}
