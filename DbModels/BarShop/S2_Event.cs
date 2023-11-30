using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_Event
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string charge_use { get; set; } = null!;

    public int charge_use_seq { get; set; }

    public int charge_use_num { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
