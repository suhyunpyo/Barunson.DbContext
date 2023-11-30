using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[PrimaryKey("id", "std_dt")]
public partial class coupon_hist
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Key]
    public DateOnly std_dt { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string benefit_type { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int benefit_price { get; set; }

    [Column(TypeName = "int(11)")]
    public int benefit_round_unit { get; set; }

    [Column(TypeName = "int(11)")]
    public int issue_limit { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
}
