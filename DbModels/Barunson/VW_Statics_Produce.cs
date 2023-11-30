using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class VW_Statics_Produce
{
    [StringLength(7)]
    [Unicode(false)]
    public string? YEAR { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? DATE { get; set; }

    public int CNT_1 { get; set; }

    public int CNT_2 { get; set; }

    public int? CNT_3 { get; set; }

    public int CNT_4 { get; set; }

    public int CNT_5 { get; set; }

    public int CNT_6 { get; set; }

    public int CNT_7 { get; set; }

    public int CNT_8 { get; set; }

    public int? CNT_9 { get; set; }

    public int CNT_10 { get; set; }
}
