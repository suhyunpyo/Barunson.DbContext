using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class except_choan_view_list
{
    public int order_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }
}
