using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("pdate", "pseq", "pid")]
public partial class TODAY_PRINTJOB
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string pdate { get; set; } = null!;

    [Key]
    public int pseq { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? src_pdate { get; set; }
}
