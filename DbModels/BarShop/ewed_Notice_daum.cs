using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Notice_daum
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    public int? viewcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mdate { get; set; }
}
