using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class gurim_coupon_event
{
    [StringLength(255)]
    public string? coupon_seq { get; set; }

    [Key]
    public int seq { get; set; }

    [StringLength(1)]
    public string? used { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? company_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? id { get; set; }
}
