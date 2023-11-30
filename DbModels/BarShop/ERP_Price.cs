using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ERP_Price
{
    [StringLength(20)]
    public string ItemCode { get; set; } = null!;

    [StringLength(80)]
    public string ItemName { get; set; } = null!;

    [Column(TypeName = "decimal(28, 8)")]
    public decimal? ERP_Daeri { get; set; }

    [Column(TypeName = "decimal(28, 8)")]
    public decimal? ERP_Sobi { get; set; }

    [Column(TypeName = "decimal(28, 8)")]
    public decimal? ERP_Chool { get; set; }

    [StringLength(5)]
    public string? DesignCode { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? UpdateDate { get; set; }
}
