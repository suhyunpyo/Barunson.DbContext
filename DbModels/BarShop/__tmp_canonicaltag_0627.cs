using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class __tmp_canonicaltag_0627
{
    [StringLength(50)]
    public string sitecode { get; set; } = null!;

    [StringLength(50)]
    public string device { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    [StringLength(250)]
    public string? url { get; set; }

    [StringLength(250)]
    public string? keyvaluestring { get; set; }

    [StringLength(250)]
    public string? canonicaluri { get; set; }

    [StringLength(250)]
    public string? Title { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }
}
