using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class COMPANY_MEMO
{
    [Key]
    public int id { get; set; }

    public int company_seq { get; set; }

    [StringLength(1000)]
    public string memo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
