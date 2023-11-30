﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_COMMENT
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string writer_name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    public int? order_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? product_order_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? best_reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? comm_div { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? up_file { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? score { get; set; }
}
