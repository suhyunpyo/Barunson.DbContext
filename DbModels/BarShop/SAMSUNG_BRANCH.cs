using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("branch_code", "status")]
public partial class SAMSUNG_BRANCH
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string branch_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? branch_name { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? branch_addr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? branch_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? branch_hphone { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string status { get; set; } = null!;
}
