using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_EVENT_REPLY
{
    [Key]
    public int seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string reply { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string event_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
