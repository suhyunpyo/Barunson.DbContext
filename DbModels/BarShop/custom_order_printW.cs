using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_printW
{
    [Key]
    public int order_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime proc_date1 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date3 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;
}
