using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CJ_API_LOG
{
    [Key]
    public int logseq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ORDER_SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KIND { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? RESULT_CODE { get; set; }

    [StringLength(1000)]
    public string? RESULT_MSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
