using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("greeting_nvarchar", Schema = "invtmng")]
public partial class greeting_nvarchar
{
    public int greeting_seq { get; set; }

    public int greeting_category_seq { get; set; }

    [StringLength(50)]
    public string? greeting_name { get; set; }

    [StringLength(2000)]
    public string? greeting_content { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isDP { get; set; } = null!;
}
