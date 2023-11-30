using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class recycle_agree_log
{
    [Key]
    public int seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int order_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }
}
