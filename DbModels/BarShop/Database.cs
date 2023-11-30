using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("Database", Schema = "invtmng")]
public partial class tbDatabase
{
    [StringLength(7)]
    public string ZIPCODE { get; set; } = null!;

    [StringLength(20)]
    public string SIDO { get; set; } = null!;

    [StringLength(50)]
    public string GUGUN { get; set; } = null!;

    [StringLength(50)]
    public string DONG { get; set; } = null!;

    [StringLength(50)]
    public string? BUNJI { get; set; }

    [Column(TypeName = "money")]
    public decimal? SEQ { get; set; }
}
