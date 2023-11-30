using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("member_id", "zzim_type", "zzim_id", "company_seq")]
public partial class THE_ZZIM
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    /// <summary>
    /// G:인사말,M:약도
    /// </summary>
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string zzim_type { get; set; } = null!;

    [Key]
    public int zzim_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [Key]
    public int company_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
