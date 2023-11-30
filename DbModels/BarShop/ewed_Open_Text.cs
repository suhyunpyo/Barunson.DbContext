using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Open_Text
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string pwd { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime idate { get; set; }
}
