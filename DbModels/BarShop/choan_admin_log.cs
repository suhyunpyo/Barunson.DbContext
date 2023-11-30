using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("order_seq", Name = "ix_order_seq")]
public partial class choan_admin_log
{
    [Key]
    public int seq { get; set; }

    public int? order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? worker_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? screen_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? function_name { get; set; }
}
