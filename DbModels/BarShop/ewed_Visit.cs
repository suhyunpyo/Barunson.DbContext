using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Visit
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? v_pwd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string v_name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? v_title { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string v_message { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }
}
