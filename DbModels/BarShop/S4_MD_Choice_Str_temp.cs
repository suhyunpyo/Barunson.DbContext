using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_MD_Choice_Str_temp
{
    [Key]
    public int md_seq { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string md_text { get; set; } = null!;
}
