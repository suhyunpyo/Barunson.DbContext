using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_print_state
{
    [Key]
    public long id { get; set; }

    public short printer_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string pdate { get; set; } = null!;

    public int pseq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
