using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_talklove
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string msg_txt { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string talk_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
