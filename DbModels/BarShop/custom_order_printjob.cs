using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("cdate", "cseq", "pid")]
[Index("pdate", Name = "IX_custom_order_printjob_pdate")]
[Index("pid", Name = "IX_custom_order_printjob_pid")]
public partial class custom_order_printjob
{
    [StringLength(10)]
    [Unicode(false)]
    public string pdate { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string cdate { get; set; } = null!;

    [Key]
    public int cseq { get; set; }

    [Key]
    public long pid { get; set; }

    public int pcount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ptype { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? printer_id { get; set; }

    public int id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? printer_date { get; set; }
}
