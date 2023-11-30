using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class zipcode
{
    [Column("zipcode")]
    [StringLength(6)]
    public string? zipcode1 { get; set; }

    [StringLength(3)]
    public string? seq { get; set; }

    [StringLength(20)]
    public string? sido { get; set; }

    [StringLength(30)]
    public string? gugun { get; set; }

    [StringLength(30)]
    public string? dong { get; set; }

    [StringLength(20)]
    public string? ri { get; set; }

    [StringLength(30)]
    public string? su { get; set; }

    [StringLength(50)]
    public string? detail { get; set; }

    [StringLength(8)]
    public string? mod_date { get; set; }

    [StringLength(255)]
    public string? juso { get; set; }
}
