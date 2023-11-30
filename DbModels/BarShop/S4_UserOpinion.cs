﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_UserOpinion
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    public short? cs_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string wr_div { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string hot_line { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string view_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
