using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_EventBlog
{
    public int Seq { get; set; }

    public int Company_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Uid { get; set; } = null!;

    [StringLength(50)]
    public string Uname { get; set; } = null!;

    public int? Order_Seq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Blog_URL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cafe_URL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isSelection { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Reg_Date { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? comment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isOpen { get; set; }
}
