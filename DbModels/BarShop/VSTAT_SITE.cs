using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("vdate", "vdomain", "company_seq")]
public partial class VSTAT_SITE
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string vdate { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string vdomain { get; set; } = null!;

    public int vcnt { get; set; }

    [Key]
    public short company_seq { get; set; }
}
