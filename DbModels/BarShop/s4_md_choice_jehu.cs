using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class s4_md_choice_jehu
{
    public int md_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string jehu_id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isDisplay { get; set; } = null!;
}
