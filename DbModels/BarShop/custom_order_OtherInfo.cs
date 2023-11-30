using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_OtherInfo
{
    [Key]
    public int ORDER_SEQ { get; set; }

    [StringLength(2000)]
    public string? EditMemo { get; set; }

    [StringLength(25)]
    public string ADMIN_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
