using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_order_work
{
    public int Order_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Wid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cid { get; set; }

    public bool? Confirm_Flag { get; set; }

    [Column(TypeName = "text")]
    public string? Content { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ConDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModiDate { get; set; }

    [Column(TypeName = "text")]
    public string? ModiContent { get; set; }
}
