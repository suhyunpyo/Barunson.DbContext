using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_5hang
{
    [Key]
    public int seq { get; set; }

    public byte event_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string msg_txt1 { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string msg_txt2 { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string msg_txt3 { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string msg_txt4 { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string msg_txt5 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
