using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class SAMSUNG_MARKETING_AGREEMENT
{
    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mem_agreement { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mem_integral_collect_inform { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mem_select_collect_inform { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mem_receipt_inform { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string mem_third_agreement { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
