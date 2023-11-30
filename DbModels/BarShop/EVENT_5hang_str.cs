using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_5hang_str
{
    [Key]
    public short seq { get; set; }

    public byte event_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? str_1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? str_2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? str_3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? str_4 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? str_5 { get; set; }
}
