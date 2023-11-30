using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_EVENT_REMIND
{
    [Key]
    public int seq { get; set; }

    public int order_id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string writer { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? prod_image { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isview { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
