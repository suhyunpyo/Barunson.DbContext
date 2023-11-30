using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_EVENT_PHOTOCLIP_REPLY
{
    [Key]
    public int seq { get; set; }

    public int clip_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string reply { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
