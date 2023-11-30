﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_RESP_WEDD_CBR
{
    [StringLength(50)]
    [Unicode(false)]
    public string? mert_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_seq { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? cflag { get; set; }

    public int? amount3 { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string result_msg { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? regdate { get; set; }
}
