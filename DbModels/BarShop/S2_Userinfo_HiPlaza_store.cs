using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("si_do", "gu_gun")]
public partial class S2_Userinfo_HiPlaza_store
{
    [Key]
    [StringLength(20)]
    public string si_do { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string gu_gun { get; set; } = null!;

    [StringLength(20)]
    public string store { get; set; } = null!;

    [StringLength(4)]
    public string org_cd { get; set; } = null!;

    [StringLength(3)]
    public string stock_org_cd { get; set; } = null!;
}
