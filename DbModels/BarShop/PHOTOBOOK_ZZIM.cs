using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_ZZIM
{
    [Key]
    public int seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
