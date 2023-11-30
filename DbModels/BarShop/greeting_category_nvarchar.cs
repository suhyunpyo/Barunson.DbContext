using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("greeting_category_nvarchar", Schema = "invtmng")]
public partial class greeting_category_nvarchar
{
    public int greeting_category_seq { get; set; }

    [StringLength(50)]
    public string? greeting_category_name { get; set; }

    public int category_upper_code { get; set; }

    public short? display_seq { get; set; }

    public byte? depth { get; set; }
}
